

namespace backeryShop.Models
{
    /// <summary>
    /// ProductPack model store ProductPacks
    /// ProductPack model is mutable.
    /// 
    /// @author Shahed Mahmoudi, shahed.mahmoudi@gmail.com
    /// @since 2019-11-25
    /// </summary>
    public class ProductPack
    {
        public int id { get; set; }
        public int count { get; set; }
        public decimal price { get; set; }
        public virtual Product product { get; set; }

    }
}
