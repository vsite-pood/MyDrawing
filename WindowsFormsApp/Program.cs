using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vsite.Pood.MyDrawing.WinForms
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
            pood.MyDrawing.Model.Drawing drawing = new pood.MyDrawing.Model.Drawing();
            WinFormsController controller = new WinFormsController(drawing);
            DrawingView view = new DrawingView(controller);

            Application.Run(new Form1());
        }
    }
}
