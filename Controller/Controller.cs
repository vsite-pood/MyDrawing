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
		public readonly Drawing drawing;
		UndoRedoStacks undoRedo = new UndoRedoStacks();

		public Controller(Drawing drawing)
		{
			this.drawing = drawing;
		}

		public void AddShape(Shape shape)
		{
			ICommand command = new AddShapeCommand(drawing, shape);
			command.Execute();
			undoRedo.Add(command);
		}
		public void AddShapeToSelection(Shape shape)
		{
			drawing.Selection.Add(shape);
		}
		public Shape GetHitShape(float x, float y)
		{
			var shape = drawing.GetHitShape(x, y);
			if (shape == null)
				ClearSelection();
			return shape;
		}
		public void ClearSelection()
		{
			drawing.Selection.Clear();
		}

		public void MoveSelection(float dx, float dy)
		{
			ICommand command = new MoveSelectionCommand(drawing.Selection, dx, dy);
			command.Execute();
			undoRedo.Add(command);
		}
		public void Undo()
		{
			undoRedo.Undo();
		}
		public void Redo()
		{
			undoRedo.Redo();
		}
		public bool CanUndo => undoRedo.CanUndo();
		public bool CanRedo => undoRedo.CanRedo();
	}
}
