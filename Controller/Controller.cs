using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vsite.pood.MyDrawing.Model;

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
            ICommand command = new AddShapeCommand(drawing, shape);
            command.Execute();
        }
        public void MoveSelection(float dx, float dy) 
        {
            ICommand command = new MoveSelectionCommand(drawing.Selection, dx, dy);
            command.Execute();
        }
    }
}
