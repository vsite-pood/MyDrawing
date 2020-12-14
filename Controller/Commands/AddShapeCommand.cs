using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vsite.Pood.MyDrawing.Model;

namespace Viste.Pood.MyDrawing.Controller
{
    public class AddShapeCommand : ICommand
    {
        private Drawing drawing;
        private Shape shape;
        public AddShapeCommand(Drawing drawing, Shape shape)
        {
            this.drawing = drawing;
            this.shape = shape;
        }
        public void Execute()
        {
            drawing.Add(shape);
        }

        public void Undo()
        {
            drawing.Remove(shape);
        }
    }
}
