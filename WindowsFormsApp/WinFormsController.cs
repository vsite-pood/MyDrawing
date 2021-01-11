using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vsite.POOD.MyDrowing.WinForms
{
	class WinFormsController : Controller.Controller
	{
		private Point startPoint = new Point();
		public enum MouseClickMode
		{
			Selection,
			InsertRectangle,
			InsertEllipse
		}
		public MouseClickMode ClickMode { get; set; }
		public WinFormsController(Model.Drawing drawing) : base(drawing)
		{

		}
		public void OnMouseDown(MouseEventArgs e)
		{
			startPoint = e.Location;
			/*switch (ClickMode)
			{
				case MouseClickMode.Selection:
					Model.Shape shape = drawing.GetHitShape(e.X, e.Y);
					if (shape != null)
						drawing.Selection.Add(shape);
					break;
				case MouseClickMode.InsertRectangle:
				case MouseClickMode.InsertEllipse:
					break;
			}*/
		}
		public void OnMouseMove(MouseEventArgs e)
		{

		}
		public void OnMouseUp(MouseEventArgs e)
		{
			float width = Math.Abs(e.X - startPoint.X);
			float hight = Math.Abs(e.Y - startPoint.Y);
			float x = Math.Min(e.X, startPoint.X);
			float y = Math.Min(e.Y, startPoint.Y);

            switch (ClickMode)
            {
                case MouseClickMode.InsertRectangle:
					drawing.Add(new Model.Rectangle(x, y, width, hight));
					break;
                case MouseClickMode.InsertEllipse:
					drawing.Add(new Model.Ellipse(x, y, width, hight));
                    break;
                default:
                    break;
            }
        }
	}
}
