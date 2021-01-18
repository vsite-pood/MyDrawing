namespace Vsite.Pood.MyDrawing.WinForms
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1Selection = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2InsertRect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3InsertEllipse = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4Undo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5Redo = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1Selection,
            this.toolStripSeparator1,
            this.toolStripButton2InsertRect,
            this.toolStripButton3InsertEllipse,
            this.toolStripSeparator2,
            this.toolStripButton4Undo,
            this.toolStripButton5Redo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1Selection
            // 
            this.toolStripButton1Selection.CheckOnClick = true;
            this.toolStripButton1Selection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1Selection.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1Selection.Image")));
            this.toolStripButton1Selection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1Selection.Name = "toolStripButton1Selection";
            this.toolStripButton1Selection.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1Selection.Text = "Selection";
            this.toolStripButton1Selection.Click += new System.EventHandler(this.toolStripButtonModeClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2InsertRect
            // 
            this.toolStripButton2InsertRect.CheckOnClick = true;
            this.toolStripButton2InsertRect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2InsertRect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2InsertRect.Image")));
            this.toolStripButton2InsertRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2InsertRect.Name = "toolStripButton2InsertRect";
            this.toolStripButton2InsertRect.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2InsertRect.Text = "InsertRectangle";
            this.toolStripButton2InsertRect.Click += new System.EventHandler(this.toolStripButtonModeClick);
            // 
            // toolStripButton3InsertEllipse
            // 
            this.toolStripButton3InsertEllipse.CheckOnClick = true;
            this.toolStripButton3InsertEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3InsertEllipse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3InsertEllipse.Image")));
            this.toolStripButton3InsertEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3InsertEllipse.Name = "toolStripButton3InsertEllipse";
            this.toolStripButton3InsertEllipse.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3InsertEllipse.Text = "InsertEllipse";
            this.toolStripButton3InsertEllipse.Click += new System.EventHandler(this.toolStripButtonModeClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4Undo
            // 
            this.toolStripButton4Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4Undo.Enabled = false;
            this.toolStripButton4Undo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4Undo.Image")));
            this.toolStripButton4Undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4Undo.Name = "toolStripButton4Undo";
            this.toolStripButton4Undo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4Undo.Text = "Undo";
            this.toolStripButton4Undo.Click += new System.EventHandler(this.toolStripButton4Undo_Click);
            // 
            // toolStripButton5Redo
            // 
            this.toolStripButton5Redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5Redo.Enabled = false;
            this.toolStripButton5Redo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5Redo.Image")));
            this.toolStripButton5Redo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5Redo.Name = "toolStripButton5Redo";
            this.toolStripButton5Redo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5Redo.Text = "Redo";
            this.toolStripButton5Redo.Click += new System.EventHandler(this.toolStripButton5Redo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "MyDrawing";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1Selection;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2InsertRect;
        private System.Windows.Forms.ToolStripButton toolStripButton3InsertEllipse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4Undo;
        private System.Windows.Forms.ToolStripButton toolStripButton5Redo;
    }
}

