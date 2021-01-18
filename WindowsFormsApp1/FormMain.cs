using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vsite.Pood.MyDrawing.WinForms
{
     partial class Form1 : Form
    {
        private DrawingView view;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(DrawingView view)
        {
            this.view = view;
            view.ModelChanged += View_ModelChanged;
            InitializeComponent();

            view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            view.Dock = System.Windows.Forms.DockStyle.Fill;
            view.Location = new System.Drawing.Point(0, 25);
            view.Name = "pictureBox1";
            view.Size = new System.Drawing.Size(800, 425);
            view.TabIndex = 1;
            view.TabStop = false;

            Controls.Add(view);
        }

        private void View_ModelChanged(object sender, EventArgs e)
        {
            toolStripButton4Undo.Enabled = view.controller.CanUndo;
            toolStripButton5Redo.Enabled = view.controller.CanRedo;
        }

        private void toolStripButtonModeClick(object sender, EventArgs e)
        {
            if(sender == toolStripButton1Selection)
            {
                toolStripButton3InsertEllipse.Checked = false;
                toolStripButton2InsertRect.Checked = false;
                view.controller.ClickMode = WinFormsController.MouseClickMode.Selection;
            }
            else if (sender == toolStripButton2InsertRect)
                {
                toolStripButton1Selection.Checked = false;
                toolStripButton3InsertEllipse.Checked = false;
                view.controller.ClickMode = WinFormsController.MouseClickMode.InsertRectangle;
            }
            else if(sender== toolStripButton3InsertEllipse)
            {
                toolStripButton1Selection.Checked = false;
                toolStripButton2InsertRect.Checked = false;
                view.controller.ClickMode = WinFormsController.MouseClickMode.InsertEllipse;
            }
        }

        private void toolStripButton4Undo_Click(object sender, EventArgs e)
        {
            view.controller.Undo();
            toolStripButton4Undo.Enabled = view.controller.CanUndo;
            toolStripButton5Redo.Enabled = view.controller.CanRedo;
        }

        private void toolStripButton5Redo_Click(object sender, EventArgs e)
        {
            view.controller.Redo();
            toolStripButton4Undo.Enabled = view.controller.CanUndo;
            toolStripButton5Redo.Enabled = view.controller.CanRedo;

        }
    }
}
