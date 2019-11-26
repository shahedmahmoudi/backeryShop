using backeryShop.DataModel;
using backeryShop.Models;
using backeryShop.Services;
using BackeryShop;
using NUnit.Framework;
using System.Collections.Generic;

namespace BuildEng.UnitTests
{
    [TestFixture]
    public class OrderTest
    {

        [Test]
        public virtual void SuccessTestInAssignment()
        {
            // Arrange
            Customer customer = new Customer { id = 1 };
            List<OrderItem> orderItem = new List<OrderItem>
            {
                new OrderItem { id = 1, Count = 10, product = StaticProduct.Vegemite_Scroll },
                new OrderItem { id = 2, Count = 14, product = StaticProduct.Blueberry_Muffin },
                new OrderItem { id = 3, Count = 13, product = StaticProduct.Croissant }
            };
            Order order = new Order { id = 1, customer = customer, orderItem = orderItem };
            OrderService orderService = new OrderService();

            //Arrange Result
            var ResultText = new List<string>();
            ResultText.Add("10 VS5 $17.98");
            ResultText.Add("    2 * 5 $8.99");
            ResultText.Add("14 MB11 $54.80");
            ResultText.Add("    1 * 8 $24.95");
            ResultText.Add("    3 * 2 $9.95");
            ResultText.Add("13 CF $25.85");
            ResultText.Add("    2 * 5 $9.95");
            ResultText.Add("    1 x 3 $5.95");
            // Act            
            List<ResultProductData> resultProductData = orderService.CalculationOrder(order);

            // Assert
            Assert.IsNotNull(resultProductData);
            int inx = 0;
            foreach (var itemProduct in resultProductData)
            {
                Assert.AreEqual(itemProduct.Result, true);
                Assert.AreEqual(itemProduct.ToString(), ResultText[inx]);
                inx++;
                foreach (var itemPack in itemProduct.ResultProductPackDatas)
                {
                    Assert.AreEqual(itemPack.ToString(), ResultText[inx]);
                    inx++;
                }
            }          
        }
    }
}