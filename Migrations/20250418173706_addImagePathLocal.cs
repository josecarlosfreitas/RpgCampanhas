using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgCampanhas.Migrations
{
    /// <inheritdoc />
    public partial class addImagePathLocal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Locais",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Locais");
        }
    }
}
