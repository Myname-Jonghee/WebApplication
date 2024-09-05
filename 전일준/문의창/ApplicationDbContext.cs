using Microsoft.EntityFrameworkCore;
using Ptoject_battery03.Models;

namespace Ptoject_battery03.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Inquiry> Inquiries { get; set; }
    }
}
