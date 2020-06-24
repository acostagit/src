using Itau.Filmes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Infra.ConfigurationEntity
{
    public class FilmeMap : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            #region Configuracoes Filme

            builder
                .Property(e => e.dsFilme)
                .HasColumnType("varchar(50)")
                .IsRequired();

            #endregion
        }
    }
}
