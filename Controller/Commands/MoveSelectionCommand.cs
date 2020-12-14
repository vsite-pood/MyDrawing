using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vsite.POOD.MyDrowing.Model;

namespace Vsite.POOD.MyDrowing.Controller
{
    public class MoveSelectionCommand : ICommand
    {
        private Selection selection;
        private float dx, dy;
        public MoveSelectionCommand(Selection selection,float dx,float dy)
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
