using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public abstract class Shape : IDrawable, IMovable, IResizable, IBounding, IHittable
    {
        public abstract RectangleF BoundingRectangle { get; }

        public abstract bool Contains(float x, float y);
        public abstract void Draw(IGraphics graphics);

        public abstract void Move(float dx, float dy);

        public abstract void Resize(ResizeDirection direction, float dx, float dy);
    }
}
