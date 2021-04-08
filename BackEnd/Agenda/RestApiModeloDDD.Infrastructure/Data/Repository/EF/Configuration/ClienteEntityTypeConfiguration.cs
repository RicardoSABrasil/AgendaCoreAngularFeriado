using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestApiModeloDDD.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Infrastructure.Data.Repository.EF.Configuration
{
    public class ClienteEntityTypeConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("TB_CLIENTE");
            builder.Property(p => p.CPF).HasMaxLength(11).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(80).IsRequired();
            builder.Property(p => p.Nome).HasMaxLength(200) .IsRequired();
            builder.Property(p => p.Sobrenome).HasMaxLength(200).IsRequired();
        }
    }
}
