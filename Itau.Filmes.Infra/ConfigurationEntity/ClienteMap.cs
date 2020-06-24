using Itau.Filmes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Infra.ConfigurationEntity
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            #region Configuracoes Cliente

            builder.HasKey(c => c.Id);

            builder
                .HasOne(c => c.Endereco)
                .WithOne(c => c.Cliente)
                .HasForeignKey<Endereco>(c => c.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(e => e.CodCliente)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder
                .Property(e => e.dsCliente)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.
                Property(e => e.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.
                Property(e => e.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();
            #endregion
        }
    }
}
