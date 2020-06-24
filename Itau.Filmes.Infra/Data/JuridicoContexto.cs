using Itau.Filmes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Infra.Data
{
    public class JuridicoContexto : DbContext
    {
        public JuridicoContexto(DbContextOptions<JuridicoContexto> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }
        public DbSet<Devolucao> Devolucoes { get; set; }
        public DbSet<Endereco> Endereco { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Filme>().ToTable("Filme");
            modelBuilder.Entity<Genero>().ToTable("Genero");
            modelBuilder.Entity<Locacao>().ToTable("Locacao");
            modelBuilder.Entity<Devolucao>().ToTable("Devolucao");
            modelBuilder.Entity<Endereco>().ToTable("Endereco");

            #region Configuracoes Cliente

            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Cliente>()
                .HasOne(c => c.Endereco)
                .WithOne(c => c.Cliente);
                
            modelBuilder.Entity<Cliente>().Property(e => e.CodCliente)
                .HasColumnType("varchar(10)")
                .IsRequired();

            modelBuilder.Entity<Cliente>().Property(e => e.dsCliente)
                .HasColumnType("varchar(50)")
                .IsRequired();

            modelBuilder.Entity<Cliente>().Property(e => e.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Cliente>().Property(e => e.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();
            #endregion

            #region Configuracoes Endereco)
            modelBuilder.Entity<Endereco>().Property(e => e.dsEndereco)
             .HasColumnType("varchar(100)")
             .IsRequired();

            modelBuilder.Entity<Endereco>().Property(e => e.Bairro)
                .HasColumnType("varchar(50)")
                .IsRequired();

            modelBuilder.Entity<Endereco>().Property(e => e.CEP)
                .HasColumnType("varchar(50)")
                .IsRequired();

            modelBuilder.Entity<Endereco>().Property(e => e.Logradouro)
                .HasColumnType("varchar(100)")
                .IsRequired();

            #endregion

            #region Configuracoes Filme
            modelBuilder.Entity<Filme>().Property(e => e.dsFilme)
              .HasColumnType("varchar(50)")
              .IsRequired();
            #endregion

            #region Configuracoes Genero

            modelBuilder.Entity<Genero>().Property(e => e.dsGenero)
                .HasColumnType("varchar(50)")
                .IsRequired();
            #endregion
        }
    }
}
