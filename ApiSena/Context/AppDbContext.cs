using ApiSena.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiSena.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Clientes> Clientes { get; set; } 
        public DbSet<ApiSena.Models.Facturas> Facturas { get; set; } = default!;
    }
}
