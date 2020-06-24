using Itau.Filmes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Infra.ConfigurationEntity
{
   public class GeneroMap : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            #region Configuracoes Genero

            builder
                .Property(e => e.dsGenero)
                .HasColumnType("varchar(50)")
                .IsRequired();

            #endregion
        }
    }
}
