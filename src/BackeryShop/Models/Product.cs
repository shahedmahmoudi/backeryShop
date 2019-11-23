using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backeryShop.Models
{
    class Product
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }      
        public virtual ProductPack productPack { get; set; }
        public virtual OrderItem orderItem { get; set; }
    }
}
