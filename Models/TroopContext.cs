using Microsoft.EntityFrameworkCore;
using ClashRoyaleApi.Enums;

namespace ClashRoyaleApi.Models
{
    public class TroopContext : DbContext
    {
        public TroopContext(DbContextOptions<TroopContext> options) : base(options)
        {
        }

        public DbSet<Troop> Troops { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Troop>().Ignore(troop => troop.Rarity);
            modelBuilder.Entity<Troop>().Ignore(troop => troop.Range);
            modelBuilder.Entity<Troop>().Ignore(troop => troop.Mechanics);
        }
    }
}
