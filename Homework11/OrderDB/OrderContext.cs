using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.EntityFramework;

namespace OrderForm
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class OrderContext : DbContext
    {
        public  OrderContext():base("OrderDatabase"){
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<OrderContext>());
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
