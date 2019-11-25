using backeryShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backeryShop.DataModel
{
    class PacksData
    {
        private   int count;
        private   ProductPack productPack;

        /// <param name="count"> </param>
        /// <param name="productPack">
        /// @return </param>
        public PacksData(int count, ProductPack productPack)
        {
            this.Count = count;
            this.ProductPack = productPack;
        }

        public int Count { get => count; set => count = value; }
        public ProductPack ProductPack { get => productPack; set => productPack = value; }

        /// <param name="count"> </param>
        /// <param name="productPack">
        /// @return </param>
        public static PacksData CreatePacksData(int count, ProductPack productPack)
        {
            return new PacksData(count, productPack);
        }


    }
}
