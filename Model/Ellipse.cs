using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Vsite.Pood.MyDrawing.Model.IResizeable;

namespace Vsite.Pood.MyDrawing.Model
{
	public class Ellipse : Shape, IDrawable, IMovable, IResizeable,IBounding
	{

		public float Left { get; private set; }
		public float Top { get; private set; }
		public float Width { get; private set; }
		public float Height { get; private set; }

		public override RectangleF BoundingRectangle => new RectangleF(Left,Top,Width,Height);

		public Ellipse(float left, float top, float width, float height)
		{
			Left = left;
			Top = top;
			Width = width;
			Width = width;
			Height = height;
		}

		public override void Draw(IGraphics graphics)
		{
			graphics.DrawEllipse( this );
		}

		public override void Move(float dx, float dy)
		{
			Left += dx;
			Top += dy;
		}

		public override void Resize(ResizeDirection direction, float dx, float dy)
		{
			throw new NotImplementedException();
		}
	}
}
