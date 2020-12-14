using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Controller
{
    public class UndoRedoStacks
    {
        public void Add(Icommand command)
        {
            undoStack.Push(command);
            redoStack.Clear();
        }
        public void Undo()
        {
            var t = undoStack.Pop();
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
        private Stack<Icommand> undoStack = new Stack<Icommand>();
        private Stack<Icommand> redoStack = new Stack<Icommand>();
    }
}
