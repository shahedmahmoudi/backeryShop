using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backeryShop.Models
{
    public class OrderItem
    {
        public int id { get; set; }
        public int Count { get; set; }
        public virtual  Product  product { get; set; }
    
    }
}
