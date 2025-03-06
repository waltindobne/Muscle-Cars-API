using Microsoft.EntityFrameworkCore;
using Muscle_Cars_API.Model;
using System.Collections.Generic;

namespace Muscle_Cars_API.Services
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Carrinho> Carrinho { get; set; }
        public DbSet<Vendidos> Vendidos { get; set; }

        public ConnectionContext(DbContextOptions<ConnectionContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=Wa2157@@;Database=DbMuscleCars;");
            }
        }
    }
}
