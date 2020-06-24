using Itau.Filmes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Infra.ConfigurationEntity
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            #region Configuracoes Endereco

            builder.HasKey(c => c.Id);

            builder
                .Property(e => e.dsEndereco)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(e => e.Bairro)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(e => e.CEP)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(e => e.Logradouro)
                .HasColumnType("varchar(100)")
                .IsRequired();

            #endregion

        }
    }
}
