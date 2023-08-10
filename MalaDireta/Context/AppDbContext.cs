using MalaDireta.Models;
using Microsoft.EntityFrameworkCore;

namespace MalaDireta.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Endereco> Enderecoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("DataSource=maladireta.db;Cache=Shared");
    }
}
