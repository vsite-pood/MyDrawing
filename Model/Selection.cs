using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public class Selection: IMovable, IResizable, IDrawable, IBounding
    {
       private readonly List<Shape> shapes = new List<Shape>();
        private readonly Dictionary<ResizeDirection, ResizeHandle> handles = new Dictionary<ResizeDirection, ResizeHandle>() {
            {ResizeDirection.North, new ResizeHandle() },
            {ResizeDirection.NorthWest, new ResizeHandle() },
            {ResizeDirection.West, new ResizeHandle() },
            {ResizeDirection.SouthWest, new ResizeHandle() },
            {ResizeDirection.South, new ResizeHandle() },
            {ResizeDirection.SouthEast, new ResizeHandle() },
            {ResizeDirection.East, new ResizeHandle() },
            {ResizeDirection.NortEast, new ResizeHandle() },
        };


        public void Add(Shape shape)
        {
            if (shapes.Contains(shape)){
                return;
            }
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

        public void Move(float dx, float dy)
        {
            foreach(Shape shape in shapes)
            {
                shape.Move(dx, dy);
            }
        }


        public void Resize(ResizeDirection direction, float dx, float dy)
        {
            foreach (Shape shape in shapes)
            {
                shape.Resize(direction, dx, dy);
            }
        }

        public void Draw(IGraphics graphics)
        {
            //Draw all shapes in selection
            foreach(IDrawable shape in shapes)
            {
                shape.Draw(graphics);
            }
            var bounds = BoundingRectangle;
            bounds.Inflate(ResizeHandle.Size, ResizeHandle.Size);

            handles[ResizeDirection.NorthWest].MoveTo(bounds.Left, bounds.Top);
            handles[ResizeDirection.North].MoveTo(bounds.Left+bounds.Width/2, bounds.Top);
            handles[ResizeDirection.NortEast].MoveTo(bounds.Right, bounds.Top);
            handles[ResizeDirection.East].MoveTo(bounds.Left, bounds.Top+ bounds.Height/2);
            handles[ResizeDirection.SouthEast].MoveTo(bounds.Right, bounds.Bottom);
            handles[ResizeDirection.South].MoveTo(bounds.Left+bounds.Width/2, bounds.Bottom);
            handles[ResizeDirection.SouthWest].MoveTo(bounds.Left, bounds.Bottom);
            handles[ResizeDirection.West].MoveTo(bounds.Left, bounds.Top+bounds.Height/2);
            //Arange Handles

            //Draw Handles
            foreach(var item in handles)
            {
                graphics.drawHandle(item.Value);
            }
        }

        public RectangleF BoundingRectangle
        {
            get
            {
                if (shapes.Count == 0)
                    return RectangleF.Empty;
                var bounds = shapes.Select(s => s.BoundingRectangle);
                return bounds.Aggregate((r1, r2) => RectangleF.Union(r1, r2));
            }
        }
    }
}
