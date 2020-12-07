using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.POOD.MyDrowing.Model;

namespace Vsite.POOD.MyDrowing.UnitTests
{
    [TestClass]
    public class testHittable
    {
        [TestMethod]
        public void ContainsReturnsTrueForAPointInsideShape()
        {
            Shape s1 = new Rectangle(10, 20, 100, 50);
            Assert.IsTrue(s1.Contains(20, 30));
            Shape s2 = new Rectangle(10, 20, 100, 50);
            Assert.IsTrue(s2.Contains(20, 30));
        }

        [TestMethod]
        public void ContainsReturnsFalseForAPointInsideShape()
        {
            Shape s1 = new Rectangle(10, 20, 100, 50);
            Assert.IsFalse(s1.Contains(120, 30));
            Shape s2 = new Rectangle(10, 20, 100, 50);
            Assert.IsFalse(s2.Contains(0, 00));
        }
    }
}
