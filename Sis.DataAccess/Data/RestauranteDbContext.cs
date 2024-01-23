using Microsoft.EntityFrameworkCore;
using Sis.Models;

namespace SistemaRestaurante.Sis.DataAccess.Data
{
    public class RestauranteDbContext:DbContext
    {
        public RestauranteDbContext(DbContextOptions<RestauranteDbContext> options) : base(options) { } 

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Cardapio> Cardapio {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { Id=1, Name="teste", Value =200}
                );
            modelBuilder.Entity<Cardapio>().HasData(
                new Cardapio { Id = 1, Name = "Prato teste", Price = 24.90, Size = 4, Description = "Um prato teste, para testar o modelo" }
                );
        }

/*        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cardapio>().HasData(
                new Cardapio { Id=1, Name="Prato teste", Price=24.90, Size=4, Description="Um prato teste, para testar o modelo" }
                );
        }*/
    }
}
