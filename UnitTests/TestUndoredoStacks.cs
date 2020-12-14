using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.POOD.MyDrowing.Controller;
using Vsite.POOD.MyDrowing.Model;

namespace Vsite.POOD.MyDrowing.UnitTests
{
    [TestClass]
    public class TestUndoredoStacks
    {
        [TestMethod]
        public void UndoAndRedoMoveBetwweUndoAndredoStack()
        {
            UndoRedoStacks stack = new UndoRedoStacks();
            Drawing drawing = new Drawing();
            Shape shape = new Rectangle(10, 20, 30, 40);
            ICommand command = new AddShapeCommand(drawing, shape);
            stack.Add(command);
            Assert.IsTrue(stack.CanUndo());
            Assert.IsFalse(stack.CanRedo());
            stack.Undo();
            Assert.IsTrue(stack.CanRedo());
            Assert.IsFalse(stack.CanUndo());
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
            ICommand command = new AddShapeCommand(drawing, shape);
            stack.Add(command);
            Assert.IsTrue(stack.CanUndo());
            Assert.IsFalse(stack.CanRedo());
            stack.Undo();
            Assert.IsTrue(stack.CanRedo());
            Assert.IsFalse(stack.CanUndo());
            stack.Redo();
            Assert.IsTrue(stack.CanUndo());
            Assert.IsFalse(stack.CanRedo());
        }
    }
}
