using TariffApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TariffApp.DAL
{
    public class TariffContext : DbContext, ITariffContext
    {
        public TariffContext(DbContextOptions<TariffContext> options) : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
        }
    }
}
