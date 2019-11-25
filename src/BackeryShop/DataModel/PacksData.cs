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
        private Product product;

        /// <param name="count"> </param>
        /// <param name="productPack">
        /// @return </param>
        public PacksData(int count, ProductPack productPack,Product product)
        {
            this.Count = count;
            this.ProductPack = productPack;
            this.Product = product;
        }

        public int Count { get => count; set => count = value; }
        public ProductPack ProductPack { get => productPack; set => productPack = value; }
        public Product Product { get => product; set => product = value; }
        
        /// <param name="count"> </param>
        /// <param name="productPack">
        /// @return </param>
        public static PacksData CreatePacksData(int count, ProductPack productPack,Product product)
        {
            return new PacksData(count, productPack,product);
        }
        public override string ToString()
        {
            return count + " * " + productPack.count.ToString()+" $"+ProductPack.price;
        }

    }
}
