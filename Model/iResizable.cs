using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public enum ResizeDirection
    {
        North,
        NorthEast,
        East,
        SouthEast,
        South,
        SouthWesst,
        West,
        WestEast
    }
    public interface iResizable
    {
        void Resize(ResizeDirection direction, float dx, float dy);
    }
}
