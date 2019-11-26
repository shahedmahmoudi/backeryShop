using backeryShop.DataModel;
using backeryShop.Models;
using System.Collections.Generic;


namespace backeryShop.Interfaces
{
    /// <summary>
    ///  Interface for  OrderItemService
    /// 
    /// @author Shahed Mahmoudi, shahed.mahmoudi@gmail.com
    /// @since 2019-11-25
    /// </summary>
    interface IOrderItemService
    {
        int GetAllOfPack(OrderItem orderItem);
        List<ResultProductPackData> findBestPack(List<List<ResultProductPackData>> packDat);
        decimal calculateTotalPrice(List<ResultProductPackData> answer);
        int totalCount(List<ResultProductPackData> answer);
    }
}
