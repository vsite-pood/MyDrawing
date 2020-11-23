using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.POOD.MyDrowing.Model
{
    public class Ellipse : Shape, IDrawable
    {
        public Ellipse(float left, float top, float width, float height)
        {
            this.left = left;
            this.top = top;
            this.width = width;
            this.height = height;
        }

        private float left, top, width, height;
        public override void Draw(IGraphics graphics)
        {
            graphics.DrawEllipse(this);
        }
    }
}
