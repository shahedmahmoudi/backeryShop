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
        public void init()
        {
            Item i = new Item();
            int p = i.Add();
            Assert.AreEqual(p, 1);



            //// Arrange
            //double beginningBalance = 11.99;
            //double debitAmount = 4.55;
            //double expected = 7.44;
            //BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            //// Act
            //account.Debit(debitAmount);

            //// Assert
            //double actual = account.Balance;
            //Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
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

            // Act            
            List<ResultProductPackData> ListPackResult = orderService.CalculationOrder(order);
            Assert.IsNotNull(ListPackResult);
            

        }
    }
}