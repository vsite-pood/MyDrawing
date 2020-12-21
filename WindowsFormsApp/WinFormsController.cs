using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vsite.pood.MyDrawing.Model;
using Vsite.Pood.MyDrawing.Controller;

namespace Vsite.Pood.MyDrawing.WinForms
{
    class WinFormsController : Controller.Controller
    {
        public enum MouseClickMode
        {
            Selection,
            InsertRectangle,
            InsertEllipse
        }
        public MouseClickMode ClickMode { get; set; }
        public WinFormsController(Drawing drawing) : base(drawing)
        {
 
        }
        public void OnMouseDown(MouseEventArgs e)
        {
            switch (ClickMode)
            {
                case MouseClickMode.Selection:
                    Shape shape = drawing.GetHitShape(e.X, e.Y);
                    if(shape != null)
                    {
                        drawing.Selection.Add(shape);
                    }
                    break;
            }
        }

        public void OnMouseMove(MouseEventArgs e)
        {

        }

        public void OnMouseUp(MouseEventArgs e)
        {

        }
    }
}
