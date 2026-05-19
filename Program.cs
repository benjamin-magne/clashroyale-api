using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using ClashRoyaleApi.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
var troopDatabaseConnectionString = builder.Configuration.GetConnectionString("TroopDatabase")
    ?? throw new InvalidOperationException("Connection string 'TroopDatabase' is missing.");

var sqliteConnectionString = new SqliteConnectionStringBuilder(troopDatabaseConnectionString);
var databaseDirectory = Path.GetDirectoryName(Path.GetFullPath(sqliteConnectionString.DataSource));

if (!string.IsNullOrWhiteSpace(databaseDirectory))
{
    Directory.CreateDirectory(databaseDirectory);
}

builder.Services.AddDbContext<TroopContext>(opt =>
    opt.UseSqlite(troopDatabaseConnectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUi(options =>
    {
        options.DocumentPath = "/openapi/v1.json";
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
