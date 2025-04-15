using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgCampanhas.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFicha3detNullableFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Equipamento",
                table: "Ficha3Dets");

            migrationBuilder.DropColumn(
                name: "Magias",
                table: "Ficha3Dets");

            migrationBuilder.DropColumn(
                name: "Pericias",
                table: "Ficha3Dets");

            migrationBuilder.AlterColumn<string>(
                name: "Vantagens",
                table: "Ficha3Dets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Notas",
                table: "Ficha3Dets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Historia",
                table: "Ficha3Dets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Desvantagens",
                table: "Ficha3Dets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "DinheiroEItens",
                table: "Ficha3Dets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MagiasConhecidas",
                table: "Ficha3Dets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Ficha3Dets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Pontos",
                table: "Ficha3Dets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PontosDeExperiencia",
                table: "Ficha3Dets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TiposDeDano",
                table: "Ficha3Dets",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DinheiroEItens",
                table: "Ficha3Dets");

            migrationBuilder.DropColumn(
                name: "MagiasConhecidas",
                table: "Ficha3Dets");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Ficha3Dets");

            migrationBuilder.DropColumn(
                name: "Pontos",
                table: "Ficha3Dets");

            migrationBuilder.DropColumn(
                name: "PontosDeExperiencia",
                table: "Ficha3Dets");

            migrationBuilder.DropColumn(
                name: "TiposDeDano",
                table: "Ficha3Dets");

            migrationBuilder.AlterColumn<string>(
                name: "Vantagens",
                table: "Ficha3Dets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Notas",
                table: "Ficha3Dets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Historia",
                table: "Ficha3Dets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Desvantagens",
                table: "Ficha3Dets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Equipamento",
                table: "Ficha3Dets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Magias",
                table: "Ficha3Dets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pericias",
                table: "Ficha3Dets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
