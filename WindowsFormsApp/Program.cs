using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vsite.POOD.MyDrowing.WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Model.Drawing drawing = new Model.Drawing();
            WinFormsController controller = new WinFormsController(drawing);
            DrawingView drawingView = new DrawingView(controller);

            Application.Run(new FormMain());
        }
    }
}
