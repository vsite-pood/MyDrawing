using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vsite.Pood.MyDrawing.WindowsForms
{
    partial class Form1 : Form
    {
        DrawingView view;
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
            view.BackColor = System.Drawing.SystemColors.Window;
            view.Dock = System.Windows.Forms.DockStyle.Fill;
            view.Location = new System.Drawing.Point(0, 27);
            view.Name = "pictureBox1";
            view.Size = new System.Drawing.Size(1217, 479);
            view.TabIndex = 2;
            view.TabStop = false;

            Controls.Add(view);
        }

        private void View_ModelChanged(object sender, EventArgs e)
        {
            toolStripButtonUndo.Enabled = view.controller.CanUndo;
            toolStripButtonRedo.Enabled = view.controller.CanRedo;
        }

        private void toolStripButtonMode_Click(object sender, EventArgs e)
        {
            if(sender== toolStripButtonSelection)
            {
                toolStripButtonSelection.Checked = false;
                toolStripButtonInsertRectangle.Checked = false;
                view.controller.ClickMode = WinFormsController.MouseClickMode.Selection;

            }
            if (sender == toolStripButtonInsertEllipse)
            {
                toolStripButtonSelection.Checked = false;
                toolStripButtonInsertRectangle.Checked = false;
                view.controller.ClickMode = WinFormsController.MouseClickMode.InsertEllipse;

            }
            if (sender == toolStripButtonInsertRectangle)
            {
                toolStripButtonSelection.Checked = false;
                toolStripButtonInsertEllipse.Checked = false;
                view.controller.ClickMode = WinFormsController.MouseClickMode.InsertRectangle;

            }
        }

        private void toolStripButtonUndo_Click(object sender, EventArgs e)
        {
            view.controller.Undo();
            toolStripButtonUndo.Enabled = view.controller.CanUndo;
            toolStripButtonRedo.Enabled = view.controller.CanRedo;
        }

        private void toolStripButtonRedo_Click(object sender, EventArgs e)
        {
            view.controller.Redo();
            toolStripButtonRedo.Enabled = view.controller.CanRedo;
            toolStripButtonUndo.Enabled = view.controller.CanUndo;
        }
    }
}
