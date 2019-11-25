using backeryShop.DataModel;
using backeryShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        List<ResultData> CalculationOrder(Order order)
    }
}
