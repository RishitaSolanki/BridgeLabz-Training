using Microsoft.EntityFrameworkCore;
using FundooApp.ModelLayer.Entities;

namespace FundooApp.RepositoryLayer.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}