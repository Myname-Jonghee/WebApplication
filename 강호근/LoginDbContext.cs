using Microsoft.EntityFrameworkCore;

namespace Project_Battery.Models
{
    public class LoginDbContext : DbContext
    {
        public LoginDbContext(DbContextOptions<LoginDbContext> options)
            : base(options)
        {
        }

        public DbSet<Login> Logins { get; set; }
    }
}
