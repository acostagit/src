using Itau.Filmes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Filmes.Infra.ConfigurationEntity
{
    public class LocacaoMap : IEntityTypeConfiguration<Locacao>
    {
        public void Configure(EntityTypeBuilder<Locacao> builder)
        {
            builder.HasKey(c => c.Id);

            builder
                .HasOne(x => x.Cliente);

            builder
                .HasOne(f => f.Filme);

        }
    }
}
