using System.Collections.Generic;

namespace backeryShop.Models
{
    /// <summary>
    /// Order model store Orders
    /// Order model is mutable.
    /// 
    /// @author Shahed Mahmoudi, shahed.mahmoudi@gmail.com
    /// @since 2019-11-25
    /// </summary>
    public class Order
    {    
        public int id { get; set; }
        public virtual Customer customer { get; set; }
        public virtual List<OrderItem> orderItem { get; set; }
    }
}
