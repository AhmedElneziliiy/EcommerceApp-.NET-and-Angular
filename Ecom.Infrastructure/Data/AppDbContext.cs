﻿
using System.Reflection;
using Ecom.Core.Entities.Product;
using Microsoft.EntityFrameworkCore;

namespace Ecom.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Category>Categories{ get; set; }
        public virtual DbSet<Product> Products{ get; set; }
        public virtual DbSet<Photo> Photos{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
