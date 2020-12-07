using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.pood.MyDrawing.Model
{
    public abstract class Shape : IDrawable, IMoveable, IResizeable, IBounding, IHitable
    {
        public abstract RectangleF BoundingRectangle { get; }

        public abstract bool Contains(float x, float y);

        public abstract void Draw(IGraphics graphics);
        public abstract void Move(float dx, float dy);
        public abstract void Resize(ResizeDirection diretion, float dx, float dy);
    }
}
