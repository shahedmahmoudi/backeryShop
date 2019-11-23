using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backeryShop.Models
{
    class Order
    {
        public int id { get; set; }
        public virtual ICollection<Customer> customers { get; set; }
        public virtual OrderItem orderItem { get; set; }

    }
}
