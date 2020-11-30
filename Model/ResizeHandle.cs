using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public class ResizeHandle : IDrawable
    {
        public const float Size = 10;

        public float X { get; private set; }
        public float Y { get; private set; }
        public void Draw(IGraphics g)
        {
            g.DrawHandle(this);
        }

        public void MoveTo(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}
