﻿using backeryShop.DataModel;
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
        public  string CalculationOrder(Order order)
        {
            List<OrderItem> orderItem = order.orderItem;
            string result = "";
            foreach (var Oitem in orderItem)
            {
                OrderItemService orderItemService = new OrderItemService();
                List<List<PacksData>> packDat = orderItemService.GetAllOfPack(Oitem);                 
                List<PacksData> BestPack = orderItemService.findBestPack(packDat);
                foreach (var BestItem in BestPack)
                {
                    result += BestItem.ProductPack.price.ToString() + "   " + BestItem.Count.ToString() + " ta \n";
                }
            }

            return result;
        }
    }
}
