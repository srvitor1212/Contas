﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InfraData.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        { }

        public DbSet<Dividas> Dividas { get; set; }
        public DbSet<Entradas> Entradas { get; set; }
        public DbSet<Pagamentos> Pagamentos { get; set; }
        public DbSet<Recebedores> Recebedores { get; set; }
        public DbSet<PagamentoDeDividas> PagamentoDeDividas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
