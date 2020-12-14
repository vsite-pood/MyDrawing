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
            ICommand command = new AddShapeCommand(drawing, shape);
            command.Execute();
        }

        public void MoveSelection(float dx, float dy) {
            ICommand command = new MoveSelectionCommand(drawing.Selection, dx, dy);
            command.Execute();
        }

    }
}
