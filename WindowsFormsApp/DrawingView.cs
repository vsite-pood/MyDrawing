using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vsite.POOD.MyDrowing.WinForms
{
	class DrawingView : PictureBox
	{
		private WinFormsController controller;
		public DrawingView(WinFormsController controller)
		{
			this.controller = controller;
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			controller.OnMouseDown(e);
		}
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			controller.OnMouseMove(e);
		}
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			controller.OnMouseUp(e);
		}
	}
}
