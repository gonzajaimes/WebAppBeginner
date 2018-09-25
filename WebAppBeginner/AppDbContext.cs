using Microsoft.EntityFrameworkCore;

namespace WebAppBeginner
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) 
            : base(options)
        {


        }
        public DbSet<Customer> Customers { get; set; }
    }
}