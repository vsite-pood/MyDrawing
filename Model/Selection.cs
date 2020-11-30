using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.POOD.MyDrowing.Model
{
    public class Selection : IMovable, IResizeble, IDrawable
    {
        private readonly List<Shape> shapes = new List<Shape>();
        private readonly Dictionary<ResizeDirection, ResizeHandle> handles = new Dictionary<ResizeDirection, ResizeHandle>()
        {
            { ResizeDirection.NorthWest, new ResizeHandle() },
            { ResizeDirection.NorthEast, new ResizeHandle() },
            { ResizeDirection.North, new ResizeHandle() },
            { ResizeDirection.East, new ResizeHandle() },
            { ResizeDirection.West, new ResizeHandle() },
            { ResizeDirection.South, new ResizeHandle() },
            { ResizeDirection.SouthEast, new ResizeHandle() },
            { ResizeDirection.SouthWest, new ResizeHandle() },
        };
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

        public void Draw(IGraphics graphics)
        {
            // draw all shapes in selection
            // arrange handeles 
            // draw handels
            throw new NotImplementedException();
        }
    }
}
