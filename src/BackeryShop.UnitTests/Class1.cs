using backeryShop.Models; 
using BackeryShop;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace BuildEng.UnitTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void init()
        {
            Item i = new Item();
            int p = i.Add();
            Assert.AreEqual(p, 1);
        }
    }
}