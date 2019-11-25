

namespace backeryShop.Models
{
    /// <summary>
    /// Order Item model store OrderItems
    /// OrderItem model is mutable.
    /// 
    /// @author Shahed Mahmoudi, shahed.mahmoudi@gmail.com
    /// @since 2019-11-25
    /// </summary>
    public class OrderItem
    {
        public int id { get; set; }
        public int Count { get; set; }
        public virtual  Product  product { get; set; }
        

    }
}
