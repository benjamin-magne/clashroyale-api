using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClashRoyaleApi.Migrations
{
    /// <inheritdoc />
    public partial class vDeux : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stats_Rarity_Champion",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Rarity_Common",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Rarity_Epic",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Rarity_Evolution",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Rarity_Hero",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Rarity_Legendary",
                table: "Troops");

            migrationBuilder.DropColumn(
                name: "Stats_Rarity_Rare",
                table: "Troops");

            migrationBuilder.RenameColumn(
                name: "Stats_TroopType_Troop",
                table: "Troops",
                newName: "TroopType_Troop");

            migrationBuilder.RenameColumn(
                name: "Stats_TroopType_Spell",
                table: "Troops",
                newName: "TroopType_Spell");

            migrationBuilder.RenameColumn(
                name: "Stats_TroopType_Building",
                table: "Troops",
                newName: "TroopType_Building");

            migrationBuilder.AddColumn<string>(
                name: "Rarity",
                table: "Troops",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rarity",
                table: "Troops");

            migrationBuilder.RenameColumn(
                name: "TroopType_Troop",
                table: "Troops",
                newName: "Stats_TroopType_Troop");

            migrationBuilder.RenameColumn(
                name: "TroopType_Spell",
                table: "Troops",
                newName: "Stats_TroopType_Spell");

            migrationBuilder.RenameColumn(
                name: "TroopType_Building",
                table: "Troops",
                newName: "Stats_TroopType_Building");

            migrationBuilder.AddColumn<double>(
                name: "Stats_Rarity_Champion",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Rarity_Common",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Rarity_Epic",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Rarity_Evolution",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Rarity_Hero",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Rarity_Legendary",
                table: "Troops",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stats_Rarity_Rare",
                table: "Troops",
                type: "REAL",
                nullable: true);
        }
    }
}
