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



            var ResultText = new List<string>();
            ResultText.Add("10 VS5 $17.98");
            ResultText.Add("    2 * 5 $8.99");
            ResultText.Add("14 MB11 $54.80");
            ResultText.Add("    1 * 8 $24.95");
            ResultText.Add("    3 * 2 $9.95");
            ResultText.Add("13 CF $25.85");
            ResultText.Add("    2 * 5 $9.95");
            ResultText.Add("    1 x 3 $5.95");


            OrderService orderService = new OrderService();
            List<ResultProductData> td = orderService.CalculationOrder(order);
            int inx = 0;
            foreach (var item in td)
            {
                Console.WriteLine(item.ToString()+" "+ ResultText[inx]);
                if(item.ToString() == ResultText[inx])
                    Console.WriteLine("True");
                inx++;
                foreach (var item1 in item.ResultProductPackDatas)
                {
                    Console.WriteLine(item1.ToString() + " " + ResultText[inx]);
                    if (item1.ToString() == ResultText[inx])
                        Console.WriteLine("True");
                    inx++;
                }
            }

            return 1;
        }
    }
}
