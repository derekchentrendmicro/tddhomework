using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PotterShoppingCart;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PotterShoppingCart.Tests
{
    [TestClass()]
    public class PotterShoppingCartTests
    {
        [TestMethod()]
        public void getTotalAmountTest_第一集買了一本_其他都沒買_價格應為100元()
        {
            var target = new PotterShoppingCart();
            target.addToCart(1);
            var actual = target.getTotalAmount();
            var expected = 100;
            Assert.AreEqual(expected, actual);
        }
    }
}
