using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backeryShop.Models
{
  public  class ProductPack
    {
        public int id { get; set; }
        public int count { get; set; }
        public decimal price { get; set; }
        public int weight { get; set; }




        public int Compare(ProductPack other)
        {
            if (this.count == 0 || other.count == 0)
            {
                return 0;
            }

            
            return this.count.CompareTo(other.count);

        }
        //public int Compareo(ProductPack other)
        //{

        //    if (this.count > other.count)
        //    {
        //        return -1;

        //    }
        //    else if (this.count < other.count)
        //    {
        //        return 1;

        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}
    }
}
