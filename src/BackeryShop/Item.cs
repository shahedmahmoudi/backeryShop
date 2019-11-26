using System;
using System.Collections.Generic;
using backeryShop.Models;
using backeryShop.Services;
using backeryShop.DataModel;

namespace BackeryShop
{
    public class Item
    {

        public int Add()
        { 
            Customer customer = new Customer { id = 1 };
            List<OrderItem> orderItem = new List<OrderItem>
            {
                new OrderItem { id = 1, Count = 10, product = StaticProduct.Vegemite_Scroll },
                new OrderItem { id = 2, Count = 14, product = StaticProduct.Blueberry_Muffin },
                new OrderItem { id = 3, Count = 13, product = StaticProduct.Croissant }
            };

            Order order = new Order
            {
                id = 1,
                customer = customer,
                orderItem = orderItem
            };
            /////////////////
            //Product product = StaticProduct.Vegemite_Scroll;
            //Product productblue = StaticProduct.Blueberry_Muffin;
            //Customer customer = new Customer { id = 1 };
            //List<OrderItem> orderItem = new List<OrderItem>
            //{
            //    new OrderItem { id = 1, Count = 1, product = product },
            //    new OrderItem { id = 1, Count = 14, product = productblue }
            //};

            //Order order = new Order
            //{
            //    id = 1,
            //    customer = customer,
            //    orderItem = orderItem
            //};

            //Product product = StaticProduct.Vegemite_Scroll;
            //Product productblue = StaticProduct.Blueberry_Muffin;
            //Customer customer = new Customer { id = 1 };
            //List<OrderItem> orderItem = new List<OrderItem>
            //{
            //    new OrderItem { id = 1, Count = 4, product = product },
            //    new OrderItem { id = 1, Count = 14, product = productblue }
            //};

            //Order order = new Order
            //{
            //    id = 1,
            //    customer = customer,
            //    orderItem = orderItem
            //};
            OrderService orderService = new OrderService();
            List<ResultProductData> td = orderService.CalculationOrder(order);
            foreach (var item in td)
            {
                Console.WriteLine(item.ToString());
                foreach (var item1 in item.ResultProductPackDatas)
                {
                    Console.WriteLine(item1.ToString());
                }
            }

            return 1;
        }
    }
}
