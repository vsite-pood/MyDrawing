using System;
using System.Collections.Generic;
using System.Text;


namespace Vsite.Pood.MyDrawing.Controller
{
	public class UndoRedoStacks
	{
		private Stack<ICommand> undoStack = new Stack<ICommand>();
		private Stack<ICommand> redoStack = new Stack<ICommand>();
		public void Add(ICommand t)
		{
			undoStack.Push( t );
			redoStack.Clear();
		}
		public void Undo()
		{
			var t = undoStack.Pop();
			t.Undo();
			redoStack.Push( t );
		}
		public void Redo()
		{
			var t = redoStack.Pop();
			t.Execute();
			undoStack.Push( t );

		}

		public bool CanUndo()
		{
			return undoStack.Count > 0;
		}
		public bool CanRedo()
		{
			return redoStack.Count > 0;
		}

	}
}
