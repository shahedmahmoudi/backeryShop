using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backeryShop.Models
{
    class ProductPack
    {
        public int id { get; set; }
        public int count { get; set; }
        public decimal price { get; set; }
        public virtual ICollection<Product> products { get; set; }
    }
}
