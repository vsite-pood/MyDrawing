using System;
using Vsite.Pood.MyDrawing.Model;

namespace Vsite.Pood.MyDrawing.Controller
{
	public class Controller
	{
		Drawing drawing;
		public Controller(Drawing drawing )
		{
			this.drawing = drawing;
		}

		public void AddShape(Shape shape)
		{
			drawing.Add( shape );
		}

	}
}
