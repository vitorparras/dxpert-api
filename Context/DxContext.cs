using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Context
{

    public class DxContext : DbContext
    {
        public DxContext(DbContextOptions<DxContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var conexao = "Server=localhost;User Id=root;Password=;Database=apiDxpert";
                optionsBuilder
                  .UseMySql(conexao, ServerVersion.AutoDetect(conexao))
                  .EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
