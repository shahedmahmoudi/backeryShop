using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backeryShop.Models
{
    class OrderItem
    {
        public int id { get; set; }
        public int Count { get; set; }
        public virtual ICollection<Product> products { get; set; }
        public virtual ICollection<Order> orders { get; set; }
    }
}
