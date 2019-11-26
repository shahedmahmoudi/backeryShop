using backeryShop.Models;


namespace backeryShop.DataModel
{
    /// <summary>
    ///  for store all pack, best pack in transaction and Test
    /// 
    /// @author Shahed Mahmoudi, shahed.mahmoudi@gmail.com
    /// @since 2019-11-26
    /// </summary>
   public class ResultProductPackData
    {
        private   int count;
        private   ProductPack productPack;
        private Product product;

        /// <param name="count"> </param>
        /// <param name="productPack">
        /// @return </param>
        public ResultProductPackData(int count, ProductPack productPack,Product product)
        {
            this.Count = count;
            this.ProductPack = productPack;
            this.Product = product;
        }
        public ResultProductPackData(int count,  Product product)
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
        public static ResultProductPackData CreatePacksData(int count, ProductPack productPack,Product product)
        {
            return new ResultProductPackData(count, productPack,product);
        }
        public override string ToString()
        {
            return "    "+count + " * " + productPack.count.ToString()+" $"+ProductPack.price;
        }

    }
}
