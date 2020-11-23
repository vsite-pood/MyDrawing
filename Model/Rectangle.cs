using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public class Rectangle : Shape, IDrawable
    {
        public float Left { get; private set; }
        public float Top { get; private set; }
        public float Width { get; private set; }
        public float Height { get; private set; }

        public Rectangle(float left, float top, float width, float height)
        {
            Left = left;
            Top = top;
            Width = width;
            Height = height;
        }

        public override void Draw(IGraphics graphics)
        {
            graphics.DrawRectangle(this);
        }
    }
}
