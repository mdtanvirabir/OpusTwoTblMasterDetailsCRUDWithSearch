using Microsoft.EntityFrameworkCore;

namespace HelloOpus.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<SalesMaster> SalesMasters { get; set; }
        public DbSet<SalesDetails> SalesDetails { get; set; }
    }
}
