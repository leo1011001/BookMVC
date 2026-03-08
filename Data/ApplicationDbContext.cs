using Microsoft.EntityFrameworkCore;
using BookMVC.Models;

namespace BookMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
