using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db.Model
{
    public partial class Payment
    {
        public int Id { set; get; }
        public DateTime Date { set; get; }
        public string Amount { set; get; }
        public int Status { set; get; }

        public Order Order { set; get; }
    }
}
