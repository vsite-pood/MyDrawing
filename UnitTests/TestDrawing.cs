using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.Pood.MyDrawing.Model;

namespace UnitTests
{
    [TestClass]
    public class TestDrawing
    {
        [TestMethod]
        public void DrawingAddMethodAddRectangleToDrawing()
        {
            Rectangle rect = new Rectangle(10,20,30,40);
            Drawing drawing = new Drawing();
            drawing.Add(rect);
            Assert.IsTrue(drawing.Shapes.Contains(rect));
        }
        [TestMethod]
        public void DrawingAddMethodAddEllipseToDrawing()
        {
            var ellipse = new Ellipse(10, 20, 30, 40);
            Drawing drawing = new Drawing();
            drawing.Add(ellipse);
            Assert.IsTrue(drawing.Shapes.Contains(ellipse));
        }
        [TestMethod]
        public void AddMethodAddsEllipseAndRectangleToDrawing()
        {
            var ellipse = new Ellipse(10, 20, 30, 40);
            Rectangle rect = new Rectangle(10, 20, 30, 40);
            Drawing drawing = new Drawing();
            drawing.Add(ellipse);
            drawing.Add(rect);
            Assert.IsTrue(drawing.Shapes.Contains(ellipse));
            Assert.IsTrue(drawing.Shapes.Contains(rect));
        }
        [TestMethod]
        public void RemoveMethodRemoveShapeFromDrawing()
        {
            Ellipse ellipse = new Ellipse(10, 20, 30, 40);
            Drawing drawing = new Drawing();
            drawing.Add(ellipse);
            drawing.Remove(ellipse);
            Assert.IsFalse(drawing.Shapes.Contains(ellipse));
        }
        [TestMethod]
        public void ClearMethodRemovesAllShapesFromDrawing()
        {
            var ellipse = new Ellipse(10, 20, 30, 40);
            Rectangle rect = new Rectangle(10, 20, 30, 40);
            Drawing drawing = new Drawing();
            drawing.Add(ellipse);
            drawing.Add(rect);

            drawing.Clear();
            Assert.IsTrue(drawing.Shapes.Count() == 0);
        }
    }
}
