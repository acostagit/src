﻿using Itau.Filmes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Infra.Data
{
    public class JuridicoContexto: DbContext
    {
        public JuridicoContexto(DbContextOptions<JuridicoContexto> options): base(options)
        {
                
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }
        public DbSet<Devolucao> Devolucoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Filme>().ToTable("Filme");
            modelBuilder.Entity<Genero>().ToTable("Genero");
            modelBuilder.Entity<Locacao>().ToTable("Locacao");
            modelBuilder.Entity<Devolucao>().ToTable("Devolucao");
        }
    }
}
