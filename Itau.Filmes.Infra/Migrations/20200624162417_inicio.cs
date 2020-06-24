using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Itau.Filmes.Infra.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodCliente = table.Column<int>(nullable: false),
                    dsCliente = table.Column<string>(nullable: true),
                    dsEndereco = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filme",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodFilme = table.Column<int>(nullable: false),
                    dsFilme = table.Column<string>(nullable: true),
                    Dublado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dsGenero = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFilme = table.Column<int>(nullable: false),
                    IdCliente = table.Column<int>(nullable: false),
                    DataLocacao = table.Column<DateTime>(nullable: false),
                    DataDevolucao = table.Column<DateTime>(nullable: false),
                    PrecoDiaria = table.Column<decimal>(nullable: false),
                    FilmeId = table.Column<int>(nullable: true),
                    ClienteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locacao_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Locacao_Filme_FilmeId",
                        column: x => x.FilmeId,
                        principalTable: "Filme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Devolucao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataDevolucao = table.Column<DateTime>(nullable: false),
                    ValorPago = table.Column<decimal>(nullable: false),
                    ValorDesconto = table.Column<decimal>(nullable: false),
                    ValorMulta = table.Column<decimal>(nullable: false),
                    LocacaoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devolucao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Devolucao_Locacao_LocacaoId",
                        column: x => x.LocacaoId,
                        principalTable: "Locacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Devolucao_LocacaoId",
                table: "Devolucao",
                column: "LocacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_ClienteId",
                table: "Locacao",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_FilmeId",
                table: "Locacao",
                column: "FilmeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devolucao");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "Locacao");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Filme");
        }
    }
}
