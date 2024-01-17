using Microsoft.EntityFrameworkCore;
using Sis.Models;

namespace SistemaRestaurante.Sis.DataAccess.Data
{
    public class RestauranteDbContext:DbContext
    {
        public RestauranteDbContext(DbContextOptions<RestauranteDbContext> options) : base(options) { } 

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { Id=1, Name="teste", Value =200}
                );
        }
    }
}
