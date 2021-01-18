using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vsite.Pood.MyDrawing.Model;

namespace Vsite.Pood.MyDrawing.Controller.Commands
{
    public class MoveSelectionCommand : ICommand
    {
        Selection selection;
        float dx;
        float dy;

        public MoveSelectionCommand(Selection selection, float dx, float dy)
        {
            this.selection = selection;
            this.dx = dx;
            this.dy = dy;
        }

        public void Execute()
        {
            selection.Move(dx, dy);        
        }

  
        public void Undo()
        {
            selection.Move(-dx, -dy);
        }
    }
}
