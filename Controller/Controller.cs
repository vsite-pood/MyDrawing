using System;
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
			ICommand command = new AddShapeCommand( drawing, shape );
		}

		public void MoveSelection(float dx, float dy)
		{
			ICommand command = new MoveSelectionCommand( drawing.Selection, dx, dy );
			command.Execute();

		}
	}
}
