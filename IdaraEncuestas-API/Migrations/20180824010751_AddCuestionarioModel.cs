using Microsoft.EntityFrameworkCore.Migrations;

namespace IdaraEncuestasAPI.Migrations
{
    public partial class AddCuestionarioModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CuestionarioId",
                table: "Preguntas",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CuestionarioId",
                table: "Preguntas");
        }
    }
}
