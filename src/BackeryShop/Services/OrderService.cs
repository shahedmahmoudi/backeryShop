using backeryShop.DataModel;
using backeryShop.Interfaces;
using backeryShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backeryShop.Services
{
    /// <summary>
    ///  all of transaction for Order
    /// 
    /// @author Shahed Mahmoudi, shahed.mahmoudi@gmail.com
    /// @since 2019-11-25
    /// </summary>
    class OrderService: IOrderService
    {
        /// <param name="order">
        /// @return </param>
        public List<ResultData> CalculationOrder(Order order)
        {
            List<ResultData> result = new List<ResultData>();
            List<OrderItem> orderItem = order.orderItem;          
            foreach (var Oitem in orderItem)
            {

                OrderItemService orderItemService = new OrderItemService();
                List<List<PacksData>> packDat = orderItemService.GetAllOfPack(Oitem);
                if (packDat.Count > 0)
                {

                    List<PacksData> BestPack = orderItemService.findBestPack(packDat);
                    foreach (var BestItem in BestPack)
                    {
                        result.Add(new ResultData { packsData = BestItem, Result = true });

                        //result += BestItem.ToString() + "\n";// BestItem.ProductPack.price.ToString() + "   " + BestItem.Count.ToString() + " of "+BestItem.ProductPack.count +" Pack " + BestItem.Product.name + "  \n ";
                    }
                }
                else
                    result.Add(new ResultData { Result = false });
            }

            return result;
        }
    }
}
