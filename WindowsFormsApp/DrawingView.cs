using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vsite.Pood.MyDrawing.WinForms
{
    class DrawingView : PictureBox
    {
        public event EventHandler ModelChanged;
        public DrawingView(WinFormsController controller)
        {
            this.controller = controller;
            controller.drawing.ModelChanged += DrawingModelChanged;
        }

        private void DrawingModelChanged(object sender, EventArgs e)
        {
            Invalidate();
            ModelChanged?.Invoke(this, EventArgs.Empty);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            WinGraphics graphics = new WinGraphics(pe.Graphics);
            controller.drawing.Draw(graphics);
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

        public readonly WinFormsController controller;
    }
}
