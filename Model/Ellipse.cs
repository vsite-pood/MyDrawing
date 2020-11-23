using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsite.pood.MyDrawing.Model
{
    public class Ellipse : Shape, IDrawable
    {
        private float left;
        private float top;
        private float width;
        private float height;

        public Ellipse(float left, float top, float width, float height)
        {
            this.left = left;
            this.top = top;
            this.width = width;
            this.height = height;
        }
        public override void Draw(IGraphics graphics)
        {
            graphics.DrawEllipse(this);
        }
    }
}
