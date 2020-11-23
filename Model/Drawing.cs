using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsite.pood.MyDrawing.Model
{
    public class Drawing : IDrawable
    {
        private List<Shape> shapes = new List<Shape>();

        public void Draw(IGraphics graphics)
        {
            foreach (var shape in shapes)
                shape.Draw(graphics);
        }

        public void Add(Shape shape) 
        {
            shapes.Add(shape);
        }
        public void Remove(Shape shape)
        {
            shapes.Remove(shape);
        }

        public void Clear()
        {
            shapes.Clear();
        }
    }
}
