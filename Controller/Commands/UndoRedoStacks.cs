using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vsite.POOD.MyDrowing.Model;

namespace Vsite.POOD.MyDrowing.Controller
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
            var command = undoStack.Pop();
            command.Undo();
            redoStack.Push(command);
        }
        public void Redo() 
        {
            var command = redoStack.Pop();
            command.Execute();
            redoStack.Push(command);
        }
        public bool CanUndo() {
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
