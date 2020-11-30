using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.POOD.MyDrowing.Model
{
    public class Rectangle : Shape, IDrawable, IMovable
    {
        public Rectangle(float left, float top, float width, float height)
        {
            this.Left = left;
            this.Top = top;
            this.Width = width;
            this.Height = height;
        }

        public float Left { get; private set; }
        public float Top { get; private set; }
        public float Width { get; private set; }
        public float Height { get; private set; }


        public override void Draw(IGraphics graphics)
        {
            graphics.DrawRectangle(this);
        }

        public override void Move(float dx, float dy)
        {
            Left += dx;
            Top += dy;
        }
    }
}
