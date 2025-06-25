using Microsoft.EntityFrameworkCore;
using CLDV6211_ST10294003.Models;
using CLDV6211_ST10294003.Pages;

namespace CLDV6211_ST10294003.Data
{
    // See references in Program.cs
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets represent tables in the database for each entity
        public DbSet<Event> Events { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
    //(Microsoft, 2024 (DbContext); Troelsen & Japikse, 2022)
    //See references in Program.cs
}
