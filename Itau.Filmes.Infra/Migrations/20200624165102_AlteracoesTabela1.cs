using Microsoft.EntityFrameworkCore.Migrations;

namespace Itau.Filmes.Infra.Migrations
{
    public partial class AlteracoesTabela1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filme_Genero_GeneroId",
                table: "Filme");

            migrationBuilder.DropColumn(
                name: "idGenero",
                table: "Filme");

            migrationBuilder.AlterColumn<int>(
                name: "GeneroId",
                table: "Filme",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Filme_Genero_GeneroId",
                table: "Filme",
                column: "GeneroId",
                principalTable: "Genero",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filme_Genero_GeneroId",
                table: "Filme");

            migrationBuilder.AlterColumn<int>(
                name: "GeneroId",
                table: "Filme",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "idGenero",
                table: "Filme",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Filme_Genero_GeneroId",
                table: "Filme",
                column: "GeneroId",
                principalTable: "Genero",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
