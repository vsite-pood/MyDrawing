using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.Pood.MyDrawing.Controller;
using Vsite.Pood.MyDrawing.Model;

namespace Vsite.Pood.MyDrawing.UnitTests
{
    [TestClass]
    public class TestUndoRedoStacks
    {
        [TestMethod]
        public void UndoRevertsLastCommandAdded()
        {
            Drawing drawing = new Drawing();
            Shape shape = new Rectangle(10, 20, 30, 40);
            UndoRedoStacks stacks = new UndoRedoStacks();
            ICommand command = new AddShapeCommand(drawing, shape);
            command.Execute();
            stacks.Add(command);
            Assert.IsTrue(drawing.Shapes.Contains(shape));
            Assert.IsTrue(stacks.CanUndo());
            Assert.IsFalse(stacks.CanRedo());
            stacks.Undo();
            Assert.IsFalse(drawing.Shapes.Contains(shape));
            Assert.IsTrue(stacks.CanRedo());
            Assert.IsFalse(stacks.CanUndo());
       }

        [TestMethod]
        public void RedoRedoesLastCommandUndoned()
        {
            Drawing drawing = new Drawing();
            Shape shape = new Rectangle(10, 20, 30, 40);
            UndoRedoStacks stacks = new UndoRedoStacks();
            ICommand command = new AddShapeCommand(drawing, shape);
            command.Execute();
            stacks.Add(command);

            Assert.IsTrue(stacks.CanUndo());
            Assert.IsFalse(stacks.CanRedo());
            stacks.Undo();
            Assert.IsTrue(stacks.CanRedo());
            Assert.IsFalse(stacks.CanUndo());
            stacks.Redo();
            Assert.IsTrue(stacks.CanUndo());
            Assert.IsFalse(stacks.CanRedo());
        }

        [TestMethod]
        public void NewCommandClearsRedoStack()
        {
            Drawing drawing = new Drawing();
            Shape shape = new Rectangle(10, 20, 30, 40);
            Shape shape2 = new Ellipse(10, 20, 30, 40);
            UndoRedoStacks stacks = new UndoRedoStacks();
            ICommand command = new AddShapeCommand(drawing, shape);
            ICommand command2 = new AddShapeCommand(drawing, shape2);
            command.Execute();
            stacks.Add(command);

            Assert.IsTrue(stacks.CanUndo());
            Assert.IsFalse(stacks.CanRedo());
            stacks.Undo();
            Assert.IsTrue(stacks.CanRedo());
            Assert.IsFalse(stacks.CanUndo());
            command2.Execute();
            stacks.Add(command2);
            Assert.IsFalse(stacks.CanRedo());
            Assert.IsTrue(stacks.CanUndo());
        }

    }
}
