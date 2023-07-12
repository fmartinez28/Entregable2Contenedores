using Microsoft.EntityFrameworkCore;
namespace BackendNET.Models;
    public class CustomersContext : DbContext
    {
        public CustomersContext(DbContextOptions<CustomersContext> options) : base(options) { 
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
        public DbSet<Customer> Customers { get; set; }
    }