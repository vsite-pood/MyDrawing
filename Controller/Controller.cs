using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vsite.Pood.MyDrawing.Model;

namespace Vsite.Pood.MyDrawing.Controller
{
    public class Controller
    {
        Drawing drawing;
        public Controller(Drawing drawing) 
        {
            this.drawing = drawing;
        }
        public void AddShape(Shape shape)
        {
            drawing.Add(shape);
        }
    }
}
