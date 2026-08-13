using ContactApp.Model;
using Microsoft.EntityFrameworkCore;

namespace ContactApp.Repository
{
    public class ContactDbContext : DbContext
    {
        public ContactDbContext(
            DbContextOptions<ContactDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}