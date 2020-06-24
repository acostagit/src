using Microsoft.EntityFrameworkCore.Migrations;

namespace Itau.Filmes.Infra.Migrations
{
    public partial class AlteracoesTabela2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devolucao_Locacao_LocacaoId",
                table: "Devolucao");

            migrationBuilder.DropForeignKey(
                name: "FK_Locacao_Cliente_ClienteId",
                table: "Locacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Locacao_Filme_FilmeId",
                table: "Locacao");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Locacao");

            migrationBuilder.DropColumn(
                name: "IdFilme",
                table: "Locacao");

            migrationBuilder.AlterColumn<int>(
                name: "FilmeId",
                table: "Locacao",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Locacao",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LocacaoId",
                table: "Devolucao",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Devolucao_Locacao_LocacaoId",
                table: "Devolucao",
                column: "LocacaoId",
                principalTable: "Locacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locacao_Cliente_ClienteId",
                table: "Locacao",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locacao_Filme_FilmeId",
                table: "Locacao",
                column: "FilmeId",
                principalTable: "Filme",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devolucao_Locacao_LocacaoId",
                table: "Devolucao");

            migrationBuilder.DropForeignKey(
                name: "FK_Locacao_Cliente_ClienteId",
                table: "Locacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Locacao_Filme_FilmeId",
                table: "Locacao");

            migrationBuilder.AlterColumn<int>(
                name: "FilmeId",
                table: "Locacao",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Locacao",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Locacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdFilme",
                table: "Locacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "LocacaoId",
                table: "Devolucao",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Devolucao_Locacao_LocacaoId",
                table: "Devolucao",
                column: "LocacaoId",
                principalTable: "Locacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Locacao_Cliente_ClienteId",
                table: "Locacao",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Locacao_Filme_FilmeId",
                table: "Locacao",
                column: "FilmeId",
                principalTable: "Filme",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
