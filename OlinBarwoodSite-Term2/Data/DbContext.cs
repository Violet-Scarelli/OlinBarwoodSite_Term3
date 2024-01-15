using Microsoft.EntityFrameworkCore;
using OlinBarwoodSite_Term2.Models;

namespace OlinBarwoodSite_Term2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}