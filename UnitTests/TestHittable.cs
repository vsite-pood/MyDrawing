using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.pood.MyDrawing.Model;

namespace Vsite.pood.MyDrawing.UnitTests
{
    [TestClass]
    public class TestHittable
    {
        [TestMethod]
        public void ContainsReturnTrueForAPointInsideAShape()
        {
            Shape s1 = new Rectangle(10, 20, 100, 50);
            Assert.IsTrue(s1.Contains(20, 30));

            Shape s2 = new Ellipse(10, 20, 100, 50);
            Assert.IsTrue(s1.Contains(20, 30));
        }

        [TestMethod]
        public void ContainsReturnFlaseeForAPointInsideAShape()
        {
            Shape s1 = new Rectangle(10, 20, 100, 50);
            Assert.IsFalse(s1.Contains(120, 30));

            Shape s2 = new Ellipse(10, 20, 100, 50);
            Assert.IsFalse(s1.Contains(0, 0));
        }
    }
}
