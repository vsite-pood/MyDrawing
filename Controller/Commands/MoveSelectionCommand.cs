using System;
using System.Collections.Generic;
using System.Text;
using Vsite.Pood.MyDrawing.Model;

namespace Vsite.Pood.MyDrawing.Controller
{
	public class MoveSelectionCommand : ICommand
	{
		private Selection selection;
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
			selection.Move( dx, dy );
		}

		public void Undo()
		{
			selection.Move( -dx, -dy );
		}
	}
}
