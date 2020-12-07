using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.POOD.MyDrowing.Model;

namespace Vsite.POOD.MyDrowing.UnitTests
{
    [TestClass]
    public class SelectionTest
    {
        [TestMethod]
        public void BoundingRectangleForEmptySelectionIsEmptyRectangle()
        {
            Selection sel = new Selection();
            Assert.IsTrue(sel.BoundingRectangle == RectangleF.Empty);
        }

        [TestMethod]
        public void BoundingRectangleForSelectionWithSingleIsIdenticalToItsBoundingRectangle()
        {
            Selection sel = new Selection();
            Shape rect = new Model.Rectangle(10, 20, 100, 50);
            sel.Add(rect);
            Assert.IsTrue(sel.BoundingRectangle == rect.BoundingRectangle);
        }

        [TestMethod]
        public void BoundingRectangleForSelectionWithTwoIsIdenticalToItsBoundingRectangle()
        {
            Selection sel = new Selection();
            Shape rect = new Model.Rectangle(10, 20, 100, 50);
            sel.Add(rect);
            Shape ellipse = new Vsite.POOD.MyDrowing.Model.Ellipse(200, 100, 100, 50);
            sel.Add(ellipse);
            Assert.IsTrue(sel.BoundingRectangle == new RectangleF(10,20,290,130));
        }

        [TestMethod]
        public void BoundingRectangleForSelectionWithTwoOverlappingShapesIsIdenticalToItsBoundingRectangle()
        {
            Selection sel = new Selection();
            Shape rect = new Model.Rectangle(10, 20, 100, 50);
            sel.Add(rect);
            Shape ellipse = new Vsite.POOD.MyDrowing.Model.Ellipse(50, 50, 100, 50);
            sel.Add(ellipse);
            Assert.IsTrue(sel.BoundingRectangle == new RectangleF(10, 20, 140, 180));
        }
    }
}
