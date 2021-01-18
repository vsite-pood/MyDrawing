using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.pood.MyDrawing.Model
{
    public interface IHitable
    {
        bool Contains(float x, float y);
    }
}
