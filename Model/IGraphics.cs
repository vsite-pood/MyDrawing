using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsite.pood.MyDrawing.Model
{
    public interface IGraphics
    {
        void DrawRectangle(Rectangle rect);
        void DrawEllipse(Ellipse ellipse);
        void DrawHandle(ResizeHandle handle);
    }
}
