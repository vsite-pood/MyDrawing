using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.Pood.MyDrawing.Model;

namespace Vsite.Pood.MyDrawing.UnitTests
{
    [TestClass]
    public class TestSelection
    {
        [TestMethod]
        public void BoundingRectangleForEmptySelectionIsEmptyRectangle()
        {
            Selection sel = new Selection();
            Assert.IsTrue(sel.BoundingRectangle == RectangleF.Empty);
        }
        [TestMethod]
        public void BoundingRectangleForSingleShapeIsIdenticalToItsBoundingRectangle()
        {
            Selection sel = new Selection();
            Shape s = new Model.Rectangle(10, 20, 100, 50);
            sel.Add(s);
            Assert.IsTrue(sel.BoundingRectangle==s.BoundingRectangle);
        }
        [TestMethod]
        public void BoundingRectangleForTwoDisplacedShapeIsIdenticalToTheirBoundingRectangle()
        {
            Selection sel = new Selection();
            Shape s = new Model.Rectangle(10, 20, 100, 50);
            Shape f = new Model.Ellipse(200, 100, 100, 50);
            sel.Add(s);
            sel.Add(f);

            Assert.IsTrue(sel.BoundingRectangle == new RectangleF(10,20,290,130));
        }
        [TestMethod]
        public void BoundingRectangleForTwoOverlapingShapeIsIdenticalToTheirBoundingRectangle()
        {
            Selection sel = new Selection();
            Shape s = new Model.Rectangle(10, 20, 100, 50);
            Shape f = new Model.Ellipse(50, 50, 100, 50);
            sel.Add(s);
            sel.Add(f);

            Assert.IsTrue(sel.BoundingRectangle == new RectangleF(10, 20, 140, 80));
        }
    }
}
