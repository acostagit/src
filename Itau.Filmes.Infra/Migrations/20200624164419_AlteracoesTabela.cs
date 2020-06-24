using Microsoft.EntityFrameworkCore.Migrations;

namespace Itau.Filmes.Infra.Migrations
{
    public partial class AlteracoesTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GeneroId",
                table: "Filme",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idGenero",
                table: "Filme",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Filme_GeneroId",
                table: "Filme",
                column: "GeneroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Filme_Genero_GeneroId",
                table: "Filme",
                column: "GeneroId",
                principalTable: "Genero",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filme_Genero_GeneroId",
                table: "Filme");

            migrationBuilder.DropIndex(
                name: "IX_Filme_GeneroId",
                table: "Filme");

            migrationBuilder.DropColumn(
                name: "GeneroId",
                table: "Filme");

            migrationBuilder.DropColumn(
                name: "idGenero",
                table: "Filme");
        }
    }
}
