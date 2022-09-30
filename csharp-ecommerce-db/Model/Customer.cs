using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db.Model
{
    public partial class Customer
    {
        public int Id{ set; get; }
        public string Name { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }

        public List<Order> Orders { set; get; }
    }
}
