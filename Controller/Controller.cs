using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vsite.POOD.MyDrowing.Model;

namespace Vsite.POOD.MyDrowing.Controller
{
    public class Controller
    {
        Drawing drawing;
        public Controller(Drawing myDrowing) 
        {
            this.drawing = myDrowing;
        }
        public void AddShape(Shape shape) 
        {
            drawing.Add(shape);
        }

    }
}
