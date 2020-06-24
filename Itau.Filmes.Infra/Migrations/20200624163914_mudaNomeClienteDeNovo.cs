using Microsoft.EntityFrameworkCore.Migrations;

namespace Itau.Filmes.Infra.Migrations
{
    public partial class mudaNomeClienteDeNovo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locacao_tbCliente_ClienteId",
                table: "Locacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbCliente",
                table: "tbCliente");

            migrationBuilder.RenameTable(
                name: "tbCliente",
                newName: "Cliente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Locacao_Cliente_ClienteId",
                table: "Locacao",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locacao_Cliente_ClienteId",
                table: "Locacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "tbCliente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbCliente",
                table: "tbCliente",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Locacao_tbCliente_ClienteId",
                table: "Locacao",
                column: "ClienteId",
                principalTable: "tbCliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
