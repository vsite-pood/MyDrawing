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

            view.BackColor = System.Drawing.SystemColors.Window;
            view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            view.Dock = System.Windows.Forms.DockStyle.Fill;
            view.Location = new System.Drawing.Point(0, 27);
            view.Name = "pictureBox1";
            view.Size = new System.Drawing.Size(800, 423);
            view.TabIndex = 1;
            view.TabStop = false;

            Controls.Add(view);
        }

        private void View_ModelChanged(object sender, EventArgs e)
        {
            toolStripButtonUndo.Enabled = view.controller.CanUndo;
            toolStripButtonRedo.Enabled = view.controller.CanRedo;
        }

        private void toolStripButtoModeClick(object sender, EventArgs e)
        {
            if(sender == toolStripButtonSelection)
            {
                toolStripButtonInsertEllipse.Checked = false;
                toolStripButtonInsertRectangle.Checked = false;
                //TODO: forward new state to controller
                view.controller.ClickMode = WinFormsController.MouseClickMode.Selection;
            }
            else if(sender == toolStripButtonInsertEllipse)
            {
                toolStripButtonSelection.Checked = false;
                toolStripButtonInsertRectangle.Checked = false;
                //TODO: forward new state to controller
                view.controller.ClickMode = WinFormsController.MouseClickMode.InsertEllipse;

            }
            else if (sender == toolStripButtonInsertRectangle)
            {
                toolStripButtonSelection.Checked = false;
                toolStripButtonInsertEllipse.Checked = false;
                //TODO: forward new state to controller
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
