﻿// <auto-generated />
using System;
using Itau.Filmes.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Itau.Filmes.Infra.Migrations
{
    [DbContext(typeof(JuridicoContexto))]
    [Migration("20200624163914_mudaNomeClienteDeNovo")]
    partial class mudaNomeClienteDeNovo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Itau.Filmes.Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodCliente")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dsCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dsEndereco")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Itau.Filmes.Domain.Entities.Devolucao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataDevolucao")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LocacaoId")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorDesconto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorMulta")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorPago")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("LocacaoId");

                    b.ToTable("Devolucao");
                });

            modelBuilder.Entity("Itau.Filmes.Domain.Entities.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodFilme")
                        .HasColumnType("int");

                    b.Property<bool>("Dublado")
                        .HasColumnType("bit");

                    b.Property<string>("dsFilme")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Filme");
                });

            modelBuilder.Entity("Itau.Filmes.Domain.Entities.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dsGenero")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("Itau.Filmes.Domain.Entities.Locacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDevolucao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataLocacao")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FilmeId")
                        .HasColumnType("int");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdFilme")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecoDiaria")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FilmeId");

                    b.ToTable("Locacao");
                });

            modelBuilder.Entity("Itau.Filmes.Domain.Entities.Devolucao", b =>
                {
                    b.HasOne("Itau.Filmes.Domain.Entities.Locacao", "Locacao")
                        .WithMany()
                        .HasForeignKey("LocacaoId");
                });

            modelBuilder.Entity("Itau.Filmes.Domain.Entities.Locacao", b =>
                {
                    b.HasOne("Itau.Filmes.Domain.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("Itau.Filmes.Domain.Entities.Filme", "Filme")
                        .WithMany()
                        .HasForeignKey("FilmeId");
                });
#pragma warning restore 612, 618
        }
    }
}
