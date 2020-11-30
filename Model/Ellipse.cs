using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
	public class Ellipse : Shape, IDrawable, IMovable
	{

		public float Left { get; private set; }
		public float Top { get; private set; }
		public float Width { get; private set; }
		public float Height { get; private set; }

		public Ellipse(float left, float top, float width, float height)
		{
			this.Left = left;
			this.Top = top;
			this.Width = width;
			this.Width = width;
			this.Height = height;
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
	}
}
