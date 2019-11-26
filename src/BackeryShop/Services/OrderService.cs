using backeryShop.DataModel;
using backeryShop.Interfaces;
using backeryShop.Models;
using System.Collections.Generic;


namespace backeryShop.Services
{
    /// <summary>
    ///  all of transaction for Order
    /// 
    /// @author Shahed Mahmoudi, shahed.mahmoudi@gmail.com
    /// @since 2019-11-25
    /// </summary>
   public class OrderService: IOrderService
    {
        /// <param name="order">
        /// @return </param>
        public List<ResultProductData> CalculationOrder(Order order)
        {
           
            List<ResultProductData> resultProductDatas = new List<ResultProductData>();

            List<OrderItem> orderItem = order.orderItem;          
            foreach (var Oitem in orderItem)
            {

                OrderItemService orderItemService = new OrderItemService();
                List<List<ResultProductPackData>> packDat = orderItemService.GetAllOfPack(Oitem);
                if (packDat.Count > 0)
                {
                    List<ResultProductPackData> resultProductPackData = new List<ResultProductPackData>();
                    decimal PriceAll = decimal.Zero;
                    List<ResultProductPackData> BestPack = orderItemService.findBestPack(packDat);
                    foreach (var BestItem in BestPack)
                    {
                        PriceAll += BestItem.ProductPack.price * BestItem.Count;
                        resultProductPackData.Add(new ResultProductPackData(BestItem.Count, BestItem.ProductPack, BestItem.Product));                       
                    }                   
                    resultProductDatas.Add(new ResultProductData { orderItem = Oitem, PriceTotalThisOrder = PriceAll, Result = true, ResultProductPackDatas = resultProductPackData });
                }
                else
                {
                    resultProductDatas.Add(new ResultProductData { orderItem = Oitem, PriceTotalThisOrder = decimal.Zero, ResultProductPackDatas = null, Result = false });
                }
            }
            return resultProductDatas;
        }
    }
}
