using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.POOD.MyDrowing.Model
{
    public class Drawing : IDrawable
    {
        private List<Shape> shapes = new List<Shape>();
        public readonly Selection Selection = new Selection();

        public void Draw(IGraphics graphics)
        {
            foreach  (Shape element in shapes)
            {
                element.Draw(graphics);
            }
        }

        public void Add(Shape s) => shapes.Add(s);
        public void Remove(Shape s) => shapes.Remove(s);
        public void Clear() => shapes.Clear();

        public IEnumerable<Shape> Shapes { get { return shapes; } }
    }
}
