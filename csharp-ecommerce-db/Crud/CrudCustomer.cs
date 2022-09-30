using csharp_ecommerce_db.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace csharp_ecommerce_db.Crud
{
    public class CrudCustomer
    {
        public static void SetCustomer(string name, string lastName, string email )
        {
            using (EcommerceContext db = new EcommerceContext())
            {
                Customer nuovo = new Customer() { Name = name, LastName=lastName, Email=email };
                db.Add(nuovo);
                db.SaveChanges();
            }
        }

        public static List<Customer> GetAllCustomer()
        {
            using (EcommerceContext db = new EcommerceContext())
            {
                return db.Customers.ToList();
            }
        }

        public static Customer GetCustomer(int id)
        {
            using (EcommerceContext db = new EcommerceContext())
            {
                return db.Customers.Where(c=> c.Id == id).First();
            }
        }

        public static void EditCustomer(int id, Customer customer )
        {
            using (EcommerceContext db = new EcommerceContext())
            {
                Customer LastCustomer = CrudCustomer.GetCustomer(id);
                LastCustomer.Name = customer.Name;
                LastCustomer.LastName = customer.LastName;
                LastCustomer.Email = customer.Email;
            }
        }

    }
}
