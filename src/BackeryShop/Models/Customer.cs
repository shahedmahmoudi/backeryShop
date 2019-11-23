using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backeryShop.Models
{
    class Customer
    {
        public int id { get; set; }
        public virtual Order order { get; set; }
         
    }
}
