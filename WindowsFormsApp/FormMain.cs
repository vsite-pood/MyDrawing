using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vsite.POOD.MyDrowing.WinForms
{
	partial class FormMain : Form
	{
		private DrawingView view;
		public FormMain()
		{
			InitializeComponent();
		}
		public FormMain(DrawingView view)
		{
			this.view = view;
			view.ModelChanged += View_ModelChanged;
			InitializeComponent();

			view.BackColor = System.Drawing.SystemColors.Window;
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
			toolStripButtonUndo.Enabled = view.controller.CanUndo;
			toolStripButtonUndo.Enabled = view.controller.CanRedo;
		}

		private void toolStripButtonButtonMode_Click(object sender, EventArgs e)
		{
			if (sender == toolStripButtonSelection)
			{
				toolStripButtonEllipse.Checked = false;
				toolStripButtonInsertRectangle.Checked = false;
				view.controller.ClickMode = WinFormsController.MouseClickMode.Selection;

			}
			else if (sender == toolStripButtonEllipse)
			{
				toolStripButtonSelection.Checked = false;
				toolStripButtonInsertRectangle.Checked = false;
				view.controller.ClickMode = WinFormsController.MouseClickMode.InsertEllipse;

			}
			else if (sender == toolStripButtonInsertRectangle)
			{
				toolStripButtonSelection.Checked = false;
				toolStripButtonEllipse.Checked = false;
				view.controller.ClickMode = WinFormsController.MouseClickMode.InsertRectangle;

			}
		}

		private void toolStripButtonUndo_Click(object sender, EventArgs e)
		{
			view.controller.Undo();
		}
		private void toolStripButtonRedo_Click(object sender, EventArgs e)
		{
			view.controller.Redo();

		}
	}
}
