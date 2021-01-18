
namespace Vsite.Pood.MyDrawing.WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSelection = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonInsertRectangle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonInsertEllipse = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSelection,
            this.toolStripSeparator1,
            this.toolStripButtonInsertRectangle,
            this.toolStripSeparator2,
            this.toolStripButtonInsertEllipse,
            this.toolStripSeparator3,
            this.toolStripButtonUndo,
            this.toolStripSeparator4,
            this.toolStripButtonRedo});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1217, 27);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButtonSelection
            // 
            this.toolStripButtonSelection.CheckOnClick = true;
            this.toolStripButtonSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSelection.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSelection.Image")));
            this.toolStripButtonSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSelection.Name = "toolStripButtonSelection";
            this.toolStripButtonSelection.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonSelection.Text = "Selection";
            this.toolStripButtonSelection.Click += new System.EventHandler(this.toolStripButtonMode_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonInsertRectangle
            // 
            this.toolStripButtonInsertRectangle.CheckOnClick = true;
            this.toolStripButtonInsertRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInsertRectangle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInsertRectangle.Image")));
            this.toolStripButtonInsertRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInsertRectangle.Name = "toolStripButtonInsertRectangle";
            this.toolStripButtonInsertRectangle.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonInsertRectangle.Text = "InsertRectangle";
            this.toolStripButtonInsertRectangle.Click += new System.EventHandler(this.toolStripButtonMode_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonInsertEllipse
            // 
            this.toolStripButtonInsertEllipse.CheckOnClick = true;
            this.toolStripButtonInsertEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInsertEllipse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInsertEllipse.Image")));
            this.toolStripButtonInsertEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInsertEllipse.Name = "toolStripButtonInsertEllipse";
            this.toolStripButtonInsertEllipse.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonInsertEllipse.Text = "InsertEllipse";
            this.toolStripButtonInsertEllipse.Click += new System.EventHandler(this.toolStripButtonMode_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUndo.Enabled = false;
            this.toolStripButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUndo.Image")));
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonUndo.Text = "Undo";
            this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonRedo
            // 
            this.toolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRedo.Enabled = false;
            this.toolStripButtonRedo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRedo.Image")));
            this.toolStripButtonRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRedo.Name = "toolStripButtonRedo";
            this.toolStripButtonRedo.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonRedo.Text = "Redo";
            this.toolStripButtonRedo.Click += new System.EventHandler(this.toolStripButtonRedo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 506);
            this.Controls.Add(this.toolStrip2);
            this.Name = "Form1";
            this.Text = "My Drawing";
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonSelection;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonInsertRectangle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonInsertEllipse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonRedo;
    }
}

