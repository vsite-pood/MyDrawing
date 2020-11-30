using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.POOD.MyDrowing.Model
{
    public enum ResizeDirection
    {
        NorthWest,
        North, 
        NorthEast,
        East,
        SouthEast,
        South,
        SouthWest,
        West
    }
    public interface IResizeble
    {
        void Resize(ResizeDirection direction, float dx, float dy);
    }
}
