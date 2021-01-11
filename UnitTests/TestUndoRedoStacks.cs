using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Vsite.Pood.MyDrawing.Controller;
using Vsite.Pood.MyDrawing.Model;

namespace Vsite.Pood.MyDrawing.UnitTests
{
    [TestClass]
    public class TestUndoRedoStacks
    {
        [TestMethod]
        public void UndoAndRedoMoveCommandsBetweenUndoAndRedoStacks()
        {
            UndoRedoStacks stack = new UndoRedoStacks();
            Drawing drawing = new Drawing();
            Shape shape = new Rectangle(10, 20, 30, 40);
            Icommand command = new AddShapeCommand(drawing, shape);
            command.Execute();
            stack.Add(command);
            Assert.IsTrue(stack.CanUndo());
            Assert.IsFalse(stack.CanRedo());
            stack.Undo();
            Assert.IsFalse(stack.CanUndo());
            Assert.IsTrue(stack.CanRedo());
            stack.Redo();
            Assert.IsTrue(stack.CanUndo());
            Assert.IsFalse(stack.CanRedo());
        }
        [TestMethod]
        public void UndoRevertsLastCommandAdded()
        {
            UndoRedoStacks stack = new UndoRedoStacks();
            Drawing drawing = new Drawing();
            Shape shape = new Rectangle(10, 20, 30, 40);
            Icommand command = new AddShapeCommand(drawing, shape);
            command.Execute();
            stack.Add(command);
            Assert.IsTrue(drawing.Shapes.Contains(shape)); 
            stack.Undo();
            Assert.IsFalse(drawing.Shapes.Contains(shape));
        }
        [TestMethod]
        public void RedoReappliesLastCommandUndone()
        {
            UndoRedoStacks stack = new UndoRedoStacks();
            Drawing drawing = new Drawing();
            Shape shape = new Rectangle(10, 20, 30, 40);
            Icommand command = new AddShapeCommand(drawing, shape);
            command.Execute();
            stack.Add(command);
            Assert.IsTrue(drawing.Shapes.Contains(shape));
            stack.Undo();
            Assert.IsFalse(drawing.Shapes.Contains(shape));
            stack.Redo();
            Assert.IsTrue(drawing.Shapes.Contains(shape));
        }
        [TestMethod]
        public void NewCommandClearsRedoStack()
        {
            UndoRedoStacks stack = new UndoRedoStacks();
            Drawing drawing = new Drawing();
            Shape shape = new Rectangle(10, 20, 30, 40);
            Icommand command = new AddShapeCommand(drawing, shape);
            command.Execute();
            stack.Add(command);
            stack.Undo();
            Assert.IsTrue(stack.CanRedo());
            Shape shape2 = new Ellipse(20, 40, 60, 80);
            Icommand command2 = new AddShapeCommand(drawing, shape2);
            command2.Execute();
            stack.Add(command2);
            Assert.IsFalse(stack.CanRedo());
        }
    }
}
