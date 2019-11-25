using System.Collections.Generic;


namespace backeryShop.Models
{
    /// <summary>
    /// Product model store Products
    /// Product model is mutable.
    /// 
    /// @author Shahed Mahmoudi, shahed.mahmoudi@gmail.com
    /// @since 2019-11-25
    /// </summary>
    public class Product
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public virtual ICollection<ProductPack> productPacks { get; set; }

    }
}