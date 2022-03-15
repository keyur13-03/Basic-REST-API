using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Models
{
    public class DataContext:DbContext

    {
        public DataContext(DbContextOptions Options) : base(Options)
        { 
            Database.EnsureCreated();

        }
        public DbSet<Customer> Customers { get; set; }

    }
}
