using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestApiModeloDDD.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Infrastructure.Data.Repository.EF.Configuration
{
    public class ProdutoEntityTypeConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("TB_PRODUTO");
            builder.Property(p => p.Nome).HasMaxLength(200).IsRequired();
            builder.Property(p => p.Valor).HasPrecision(12, 4).IsRequired();
            builder.Property(p => p.IsDisponivel).IsRequired();
        }
    }
}
