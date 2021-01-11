using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vsite.POOD.MyDrowing.Model;

namespace Vsite.POOD.MyDrowing.WinForms
{
    class WinGraphics : Model.IGraphics
    {
        private readonly System.Drawing.Graphics graphics;
        public WinGraphics(System.Drawing.Graphics graphics)
        {
            this.graphics = graphics;
        }
        public void DrawEllipse(Ellipse ellipse)
        {
            graphics.DrawEllipse(System.Drawing.Pens.Black, ellipse.Left,ellipse.Top,ellipse.Width,ellipse.Height);
        }

        public void DrawHandle(ResizeHandle handle)
        {
            throw new NotImplementedException();
        }

        public void DrawRectangle(Rectangle rectangle)
        {
            graphics.DrawRectangle(System.Drawing.Pens.Black, rectangle.Left, rectangle.Top, rectangle.Width, rectangle.Height);
        }
    }
}
