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
            Product product = StaticProduct.Vegemite_Scroll;
            Product productblue = StaticProduct.Blueberry_Muffin;
            Product productC = StaticProduct.Croissant;
            Customer customer = new Customer { id = 1 };
            List<OrderItem> orderItem = new List<OrderItem>
            {
                new OrderItem { id = 1, Count = 10, product = product },
                new OrderItem { id = 2, Count = 14, product = productblue },
                new OrderItem { id = 3, Count = 13, product = productC }
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
            List<ResultData> td = orderService.CalculationOrder(order);
            foreach (var item in td)
            {
                Console.WriteLine(item.packsData.ToString());
            }

            return 1;
        }
    }
}
