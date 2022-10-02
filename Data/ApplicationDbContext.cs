using AddressBook.Models;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace AddressBook.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
