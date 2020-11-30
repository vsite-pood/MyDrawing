using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.POOD.MyDrowing.Model
{
    public class Selection : IMovable, IResizeble
    {
        private readonly List<Shape> shapes = new List<Shape>();
        public void Add(Shape shape) 
        {
            if (!shapes.Contains(shape))
                shapes.Add(shape);
        }
        public void Remove(Shape shape) => shapes.Remove(shape);

        public void Clear() => shapes.Clear();

        public void Move(float dx, float dy)
        {
            foreach (Shape s in shapes)
                s.Move(dx, dy);
        }

        public void Resize(ResizeDirection direction, float dx, float dy)
        {
            foreach (Shape s in shapes)
                s.Resize(direction, dx, dy);
        }
    }
}
