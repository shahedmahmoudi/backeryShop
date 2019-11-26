

using backeryShop.Models;
using System.Collections.Generic;

namespace backeryShop.DataModel
{
    /// <summary>
    ///  store result PRODUCT data just for unit Test 
    /// 
    /// @author Shahed Mahmoudi, shahed.mahmoudi@gmail.com
    /// @since 2019-11-26
    /// </summary>
    public class ResultProductData
    {
        public OrderItem orderItem;
        public decimal PriceTotalThisOrder { get; set; }
       // public PacksData packsData { get; set; }        
        public bool Result { get; set; }

        public virtual ICollection<ResultProductPackData> ResultProductPackDatas  { get; set; }

        public override string ToString()
        {
            return orderItem.Count + " " + orderItem.product.code + " $" + PriceTotalThisOrder.ToString();
        }
    }
}
