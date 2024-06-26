using Microsoft.EntityFrameworkCore;
using WS.Models;

namespace WS.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }
        public DbSet<ExameClinico> ExameClinico { get; set; }
        public DbSet<ClinicaPregressa> ClinicaPregressa { get; set; }
        public DbSet<HistoricoOcupacional> HistoricoOcupacional { get; set; }
    }
}
