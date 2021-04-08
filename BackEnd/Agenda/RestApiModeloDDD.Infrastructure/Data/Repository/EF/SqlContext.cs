using Microsoft.EntityFrameworkCore;
using RestApiModeloDDD.Domain.Entity;
using RestApiModeloDDD.Infrastructure.Data.Repository.EF.Configuration;
using System;
using System.Linq;

namespace RestApiModeloDDD.Infrastructure.Data.Repository.EF
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }

        public SqlContext(DbContextOptions<SqlContext> contextOptions) : base(contextOptions) 
        {
        
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                    entry.Property("DataAlteracao").CurrentValue = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoEntityTypeConfiguration());
        }
    }
}