using Microsoft.EntityFrameworkCore;
using RelacionamentoApi.Models;

namespace RelacionamentoApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Casa> Casas { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Quarto> Quartos { get; set; }

        public DbSet<Morador> Moradores { get; set; }
    }
}
