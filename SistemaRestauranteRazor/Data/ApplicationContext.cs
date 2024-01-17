using Microsoft.EntityFrameworkCore;
using SistemaRestauranteRazor.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace SistemaRestauranteRazor.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { Id = 1, Name = "teste", Value = 200 }
                );
        }
    }
}
