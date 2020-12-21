using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vsite.Pood.MyDrawing.Controller.Commands;
using Vsite.Pood.MyDrawing.Model;

namespace Vsite.Pood.MyDrawing.Controller
{
    public class Controller
    {
        Drawing drawing;
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
        public void MoveSelection(float dx, float dy)
        {
            ICommand command = new MoveSelectionCommand(drawing.Selection, dx, dy);
            command.Execute();
            undoRedo.Add(command);
        }
        public void Undo() { undoRedo.Undo(); }
        public void Redo() { undoRedo.Redo(); }
        public bool CanUndo => undoRedo.CanUndo();
        public bool CanRedo => undoRedo.CanRedo();
    }
}
