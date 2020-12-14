using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vsite.pood.MyDrawing.Model;

namespace Vsite.Pood.MyDrawing.Controller
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
            
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
