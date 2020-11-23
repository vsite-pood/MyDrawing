using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.POOD.MyDrowing.Model;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class TestDrawing
    {
        [TestMethod]
        public void AddMethodAddsRectangleToDrawing()
        {
            Rectangle rectangle = new Rectangle();
            Drawing drawing = new Drawing();
            drawing.Add(rectangle);
            Assert.IsTrue(drawing.Shapes.Contains(rectangle));
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
            Rectangle rectangle = new Rectangle();
            Ellipse ellipse = new Ellipse();
            Drawing drawing = new Drawing();

            drawing.Add(rectangle);
            drawing.Add(ellipse);
            Assert.IsTrue(drawing.Shapes.Contains(rectangle));
            Assert.IsTrue(drawing.Shapes.Contains(ellipse));
        }

        [TestMethod]
        public void RemoveMethodRemovesShapeFromDrawing()
        {
            Ellipse ellipse = new Ellipse();
            Drawing drawing = new Drawing();
            drawing.Add(ellipse);
            Assert.IsTrue(drawing.Shapes.Contains(ellipse));
            drawing.Remove(ellipse);
            Assert.IsTrue(drawing.Shapes.Count() == 0);
        }

        [TestMethod]
        public void ClearMethodRemovesAllShapesFromDrawing()
        {
            Rectangle rectangle = new Rectangle();
            Ellipse ellipse = new Ellipse();
            Drawing drawing = new Drawing();

            drawing.Add(rectangle);
            drawing.Add(ellipse);

            drawing.Clear();
            Assert.IsTrue(drawing.Shapes.Count()==0);
        }
    }
}
