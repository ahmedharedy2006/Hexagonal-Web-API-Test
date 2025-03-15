using DOTNet9API.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DOTNet9API.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
