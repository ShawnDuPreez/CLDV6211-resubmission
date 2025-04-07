using Microsoft.EntityFrameworkCore;
using CLDV6211_ST10294003.Models;
using CLDV6211_ST10294003.Pages;

namespace CLDV6211_ST10294003.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Your EF Core DbSets here
        public DbSet<Event> Events { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
