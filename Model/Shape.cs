using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.POOD.MyDrowing.Model
{
    public abstract class Shape : IDrawable
    {
        public abstract void Draw(IGraphics graphics);
    }
}
