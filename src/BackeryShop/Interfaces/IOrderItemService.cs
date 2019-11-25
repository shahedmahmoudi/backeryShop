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
    ///  Interface for  OrderItemService
    /// 
    /// @author Shahed Mahmoudi, shahed.mahmoudi@gmail.com
    /// @since 2019-11-25
    /// </summary>
    interface IOrderItemService
    {
        int GetAllOfPack(OrderItem orderItem);
        List<PacksData> findBestPack(List<List<PacksData>> packDat);
        decimal calculateTotalPrice(List<PacksData> answer);
        int totalCount(List<PacksData> answer);
    }
}
