using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backeryShop.Models
{
   public class Order
    {
        public int id { get; set; }
        public virtual Customer customer { get; set; }
        public virtual List<OrderItem> orderItem { get; set; }

    }
}
