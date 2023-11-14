using MalaDireta.Models;
using Microsoft.EntityFrameworkCore;

namespace MalaDireta.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecoes { get; set; }

        private readonly IConfiguration _configuration;
        public AppDbContext(IConfiguration configuration) => _configuration = configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(_configuration.GetConnectionString("DefaultConnection"));
    }
}
