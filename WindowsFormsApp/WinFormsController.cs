using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vsite.Pood.MyDrawing.Controller;

namespace Vsite.Pood.MyDrawing.WindowsForms
{
    class WinFormsController : Controller.Controller
    {
        private Point firstPoint;
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
            firstPoint = e.Location;
            //switch (ClickMode) 
            //{
            //    case MouseClickMode.Selection:
            //        Model.Shape shape = drawing.GetHitShape(e.X, e.Y);
            //        if (shape != null)
            //            drawing.Selection.Add(shape);
            //        break;
            //}
        }

        public void OnMouseMove(MouseEventArgs e)
        {
            
        }

        public void OnMouseUp(MouseEventArgs e)
        {
            float width = Math.Abs(e.X - firstPoint.X);
            float height = Math.Abs(e.Y - firstPoint.Y);
            float x = Math.Min(e.X , firstPoint.X);
            float y = Math.Min(e.Y , firstPoint.Y);
            switch (ClickMode)
            {
                case MouseClickMode.InsertEllipse:
                    AddShape(new Model.Ellipse(x, y, width, height));
                    break;
                case MouseClickMode.InsertRectangle:
                    AddShape(new Model.Rectangle(x, y, width, height));
                    break;

            }
        }
        
    }
}
