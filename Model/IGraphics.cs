using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.POOD.MyDrowing.Model
{
    public interface IGraphics
    {
        void DrawRectangle(Rectangle rectangle);
        void DrawEllipse(Ellipse ellipse);

        void DrawHandle(ResizeHandle handle);
    }
}
