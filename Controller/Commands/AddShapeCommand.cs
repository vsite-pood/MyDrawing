using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vsite.POOD.MyDrowing.Model;

namespace Vsite.POOD.MyDrowing.Controller
{
    public class AddShapeCommand : ICommand
    {
        private Drawing drawing;
        private Shape shape;
        public AddShapeCommand(Drawing drowing,Shape shape) 
        {
            this.drawing = drowing;
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
