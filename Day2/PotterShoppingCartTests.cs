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

        [TestMethod()]
        public void getTotalAmountTest_第一集買了一本_第二集也買了一本_價格應為190()
        {
            var target = new PotterShoppingCart();
            target.addToCart(1);
            target.addToCart(2);
            var actual = target.getTotalAmount();
            var expected = 190;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void getTotalAmountTest_一二三集各買了一本_價格應為270()
        {
            var target = new PotterShoppingCart();
            target.addToCart(1);
            target.addToCart(2);
            target.addToCart(3);
            var actual = target.getTotalAmount();
            var expected = 270;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void getTotalAmountTest_一二三四集各買了一本_價格應為320()
        {
            var target = new PotterShoppingCart();
            target.addToCart(1);
            target.addToCart(2);
            target.addToCart(3);
            target.addToCart(4);
            var actual = target.getTotalAmount();
            var expected = 320;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void getTotalAmountTest_一次買了整套_一二三四五集各買了一本_價格應為375()
        {
            var target = new PotterShoppingCart();
            target.addToCart(1);
            target.addToCart(2);
            target.addToCart(3);
            target.addToCart(4);
            target.addToCart(5);
            var actual = target.getTotalAmount();
            var expected = 375;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void getTotalAmountTest_一二集各買了一本_第三集買了兩本_價格應為價格應為370()
        {
            var target = new PotterShoppingCart();
            target.addToCart(1);
            target.addToCart(2);
            target.addToCart(3);
            target.addToCart(3);
            var actual = target.getTotalAmount();
            var expected = 370;
            Assert.AreEqual(expected, actual);
        }

                [TestMethod()]
        public void getTotalAmountTest_第一集買了一本_第二三集各買了兩本_價格應為價格應為460()
        {
            var target = new PotterShoppingCart();
            target.addToCart(1);
            target.addToCart(2);
            target.addToCart(2);
            target.addToCart(3);
            target.addToCart(3);
            var actual = target.getTotalAmount();
            var expected = 460;
            Assert.AreEqual(expected, actual);
        }

        


    }
}
