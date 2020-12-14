using System;
using System.Collections.Generic;
using System.Text;

namespace Vsite.Pood.MyDrawing.Controller
{
	public interface ICommand
	{
		void Execute();
		void Undo();
	}
}
