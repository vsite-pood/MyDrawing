using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vsite.pood.MyDrawing.Model;

namespace Vsite.Pood.MyDrawing.WinForms
{
    class WinGraphics : IGraphics
    {
        private readonly System.Drawing.Graphics graphics;
        public WinGraphics(System.Drawing.Graphics graphics)
        {
            this.graphics = graphics;
        }
        public void DrawEllipse(Ellipse ellipse)
        {
            graphics.DrawEllipse(System.Drawing.Pens.Black, ellipse.Left, ellipse.Top, ellipse.Width, ellipse.Height);
        }

        public void DrawHandle(ResizeHandle handle)
        {
            throw new NotImplementedException();
        }
        
        public void DrawRectangle(Rectangle rect)
        {
            graphics.DrawRectangle(System.Drawing.Pens.Azure, rect.Left, rect.Top, rect.Width, rect.Height);
        }
    }
}
