using Microsoft.EntityFrameworkCore;
namespace OrderWeb.Models
{
    public class OrderServiceContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

        public OrderServiceContext(DbContextOptions<OrderServiceContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
