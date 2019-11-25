using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backeryShop.Models; 

namespace BackeryShop
{
    public class Item
    {

        public int Add()
        {
            Product product = StaticProduct.Vegemite_Scroll;
            Product productblue = StaticProduct.Blueberry_Muffin;
            Customer customer = new Customer { id = 1 };
            List<OrderItem> orderItem = new List<OrderItem>
            {
                new OrderItem { id = 1, Count = 10, product = product },
                new OrderItem { id = 1, Count = 14, product = productblue }
            };

            Order order = new Order
            {
                id = 1,
                customer = customer,
                orderItem = orderItem
            };
           Console.Write( "" );
            return 1;
        }
    }
}
