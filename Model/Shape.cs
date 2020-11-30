using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsite.pood.MyDrawing.Model
{
    public abstract class Shape : IDrawable, IMoveable, IResizeable
    {
        public abstract void Draw(IGraphics graphics);
        public abstract void Move(float dx, float dy);
        public abstract void Resize(ResizeDirection diretion, float dx, float dy);
    }
}
