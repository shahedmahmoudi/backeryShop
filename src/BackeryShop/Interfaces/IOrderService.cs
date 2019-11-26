using backeryShop.DataModel;
using backeryShop.Models;
using System.Collections.Generic;


namespace backeryShop.Interfaces
{
    /// <summary>
    ///  Interface for  OrderService
    /// 
    /// @author Shahed Mahmoudi, shahed.mahmoudi@gmail.com
    /// @since 2019-11-25
    /// </summary>
    interface IOrderService
    {
        List<ResultProductData> CalculationOrder(Order order);
    }
}
