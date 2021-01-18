using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.pood.MyDrawing.Model;

namespace Vsite.pood.MyDrawing.UnitTests
{
    [TestClass]
    public class TestSelection
    {
        [TestMethod]
        public void BoundingRectangleForEmptySelection()
        {
            Selection sel = new Selection();
            Assert.IsTrue(sel.BoundingRectangle == RectangleF.Empty);
        }

        [TestMethod]
        public void BoundingRectangleForSelectionWithSingleShapeIsIdenticalToItsBoundingRectangle()
        {
            Selection sel = new Selection();
            Shape rect = new Model.Rectangle(10, 20, 100, 50);
            sel.Add(rect);
            Assert.IsTrue(sel.BoundingRectangle == rect.BoundingRectangle);
        }

        [TestMethod]
        public void BoundingRectangleForSelectionWithTwoShapeIsIdenticalToItsBoundingRectangle()
        {
            Selection sel = new Selection();
            Shape rect = new Model.Rectangle(10, 20, 100, 50);
            sel.Add(rect);
            Shape ellipse = new Model.Ellipse(200, 100, 100, 50);
            sel.Add(ellipse);
            Assert.IsTrue(sel.BoundingRectangle == new RectangleF(10, 20, 290, 130));
        }

        [TestMethod]
        public void BoundingRectangleForSelectionWithTwoOverlappingShapesIsIdenticalToItsBoundingRectangle()
        {
            Selection sel = new Selection();
            Shape rect = new Model.Rectangle(10, 20, 100, 50);
            sel.Add(rect);
            Shape ellipse = new Model.Ellipse(50, 50, 100, 50);
            sel.Add(ellipse);
            Assert.IsTrue(sel.BoundingRectangle == new RectangleF(10, 20, 140, 80));
        }
    }
}
