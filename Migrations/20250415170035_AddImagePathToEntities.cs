using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgCampanhas.Migrations
{
    /// <inheritdoc />
    public partial class AddImagePathToEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Personagens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "NPCs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Ficha3Dets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Campanhas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "NPCs");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Ficha3Dets");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Campanhas");
        }
    }
}
