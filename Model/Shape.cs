using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public abstract class Shape : IDrawable, iMovable, iResizable
    {
        public abstract void Draw(IGraphics g);
        public abstract void Move(float dx, float dy);
        public abstract void Resize(ResizeDirection direction, float dx, float dy);
    }
}
