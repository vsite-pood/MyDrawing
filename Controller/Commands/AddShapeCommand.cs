using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vsite.Pood.MyDrawing.Model;

namespace Vsite.Pood.MyDrawing.Controller
{
    public class AddShapeCommand : Icommand
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
            throw new NotImplementedException();
        }
    }
}
