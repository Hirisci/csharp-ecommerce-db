using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db
{
    public class EcommerceContext : DbContext
    {
        public DbSet<Model.Customer> Customers { get; set; }
        public DbSet<Model.Emploee> Employees { get; set; }
        public DbSet<Model.Order> Orders { get; set; }
        public DbSet<Model.Payment> Payments { get; set; }
        public DbSet<Model.Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=db-ecommerce;Integrated Security=True");
        }
    }
}
