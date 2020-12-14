using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
            Assert.IsTrue(stack.CanRedo());
            Assert.IsFalse(stack.CanUndo());
            stack.Redo();
            Assert.IsTrue(stack.CanUndo());
            Assert.IsFalse(stack.CanRedo());
        }
    }
}
