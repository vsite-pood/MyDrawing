using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.Pood.MyDrawing.Model;

namespace Vsite.Pood.MyDrawing.UnitTests
{
    [TestClass]
    public class TestDrawing
    {
        [TestMethod]
        public void AddMethodAddsRectangleToDrawing()
        {
            Rectangle rect = new Rectangle();
            Drawing drawing = new Drawing();
            drawing.Add(rect);
            Assert.IsTrue(drawing.Shapes.Contains(rect));
        }
        [TestMethod]
        public void AddMethodAddsEllipseToDrawing()
        {
            Ellipse ellipse = new Ellipse();
            Drawing drawing = new Drawing();
            drawing.Add(ellipse);
            Assert.IsTrue(drawing.Shapes.Contains(ellipse));
        }
        [TestMethod]
        public void AddMethodAddsEllipseAndRectangleToDrawing()
        {
            Rectangle rect = new Rectangle();
            Ellipse ellipse = new Ellipse();
            Drawing drawing = new Drawing();
            drawing.Add(ellipse);
            drawing.Add(rect);
            Assert.IsTrue(drawing.Shapes.Contains(ellipse));
            Assert.IsTrue(drawing.Shapes.Contains(rect));
        }
        [TestMethod]
        public void RemoveMethodRemovesShapeFromDrawing()
        {
            Ellipse ellipse = new Ellipse();
            Drawing drawing = new Drawing();
            drawing.Add(ellipse);
            Assert.IsTrue(drawing.Shapes.Contains(ellipse));
            drawing.Remove(ellipse);
            Assert.IsFalse(drawing.Shapes.Contains(ellipse));

        }
        [TestMethod]
        public void ClearMethodRemovesAllShapesFromDrawing()
        {
            Rectangle rect = new Rectangle();
            Ellipse ellipse = new Ellipse();
            Drawing drawing = new Drawing();
            drawing.Add(ellipse);
            drawing.Add(rect);
            Assert.IsTrue(drawing.Shapes.Contains(ellipse));
            Assert.IsTrue(drawing.Shapes.Contains(rect));
            drawing.Clear();
            Assert.IsFalse(drawing.Shapes.Contains(ellipse));
            Assert.IsFalse(drawing.Shapes.Contains(rect));
            Assert.IsTrue(drawing.Shapes.Count()==0);
        }

    }
}
