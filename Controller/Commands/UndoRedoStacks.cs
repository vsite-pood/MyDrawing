using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Controller
{
    public class UndoRedoStacks
    {
        public void Add(ICommand command)
        {
            undoStack.Push(command);
            redoStack.Clear();
        }
        public void Undo()
        {
            ICommand t = undoStack.Pop();
            t.Undo();
            redoStack.Push(t);
        }

        public void Redo()
        {
            var t = redoStack.Pop();
            t.Execute();
            undoStack.Push(t);
        }

        public bool CanUndo()
        {
            return undoStack.Count > 0;
        }

        public bool CanRedo()
        {
            return redoStack.Count > 0;
        }

        private Stack<ICommand> undoStack = new Stack<ICommand>();
        private Stack<ICommand> redoStack = new Stack<ICommand>();
    }
}
