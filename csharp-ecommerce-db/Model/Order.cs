using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db.Model
{
    public partial class Order
    {
        public int Id { set; get; }
        public DateTime Date { set; get; }
        public float Amount { set; get; }
        public string Status { set; get; }

        public Customer Customer { set; get; }
        public Emploee Emploee { set; get; }
        public List<Payment> Payment { set; get; }
        public List<Product> Products { set; get; }
    }
}
