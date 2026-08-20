using FundooApp.ModelLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace FundooApp.RepositoryLayer.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
            DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}