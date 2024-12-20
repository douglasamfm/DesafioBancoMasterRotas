using DesafioBancoMaster.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesafioBancoMaster.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options) 
        {
        }

        public DbSet<Rota> Rotas { get; set; }
    }
}
