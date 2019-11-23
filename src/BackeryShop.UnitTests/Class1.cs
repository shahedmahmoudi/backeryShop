using BackeryShop;
using NUnit.Framework;

namespace BuildEng.UnitTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void init()
        {
            Item obj = new Item();
            int result=obj.Add(11, 20);
            Assert.AreEqual(31, result);
        }
    }
}
