using DataEntities.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class Context : DbContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Supplier> Suppliers { get; set; }
        DbSet<OrderDetail> OrderDetails { get; set; }
        DbSet<ProductImages> ProductImages { get; set; }

    }
}
