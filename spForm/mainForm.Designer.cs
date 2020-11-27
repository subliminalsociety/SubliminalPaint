namespace spForm
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.panel_PaintCanvas = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_NewCanvas = new System.Windows.Forms.ToolStripButton();
            this.btn_SaveBitmap = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtbox_PenWidth = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.combo_PenColor = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.combo_BackgroundColor = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_PaintCanvas
            // 
            this.panel_PaintCanvas.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_PaintCanvas.BackColor = System.Drawing.Color.White;
            this.panel_PaintCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_PaintCanvas.Location = new System.Drawing.Point(12, 28);
            this.panel_PaintCanvas.Name = "panel_PaintCanvas";
            this.panel_PaintCanvas.Size = new System.Drawing.Size(992, 700);
            this.panel_PaintCanvas.TabIndex = 0;
            this.panel_PaintCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_PaintCanvas_MouseDown);
            this.panel_PaintCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_PaintCanvas_MouseMove);
            this.panel_PaintCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_PaintCanvas_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.btn_NewCanvas, this.btn_SaveBitmap, this.toolStripSeparator3, this.toolStripLabel1, this.txtbox_PenWidth, this.toolStripSeparator1, this.toolStripLabel2, this.combo_PenColor, this.toolStripSeparator6, this.toolStripLabel4, this.combo_BackgroundColor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1016, 40);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_NewCanvas
            // 
            this.btn_NewCanvas.AutoSize = false;
            this.btn_NewCanvas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_NewCanvas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_NewCanvas.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.btn_NewCanvas.Name = "btn_NewCanvas";
            this.btn_NewCanvas.Size = new System.Drawing.Size(60, 22);
            this.btn_NewCanvas.Text = "NEW";
            this.btn_NewCanvas.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btn_NewCanvas.Click += new System.EventHandler(this.btn_NewCanvas_Click);
            // 
            // btn_SaveBitmap
            // 
            this.btn_SaveBitmap.AutoSize = false;
            this.btn_SaveBitmap.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_SaveBitmap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SaveBitmap.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.btn_SaveBitmap.Name = "btn_SaveBitmap";
            this.btn_SaveBitmap.Size = new System.Drawing.Size(60, 22);
            this.btn_SaveBitmap.Text = "SAVE";
            this.btn_SaveBitmap.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btn_SaveBitmap.Click += new System.EventHandler(this.btn_SaveBitmap_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripSeparator3.Size = new System.Drawing.Size(25, 50);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 37);
            this.toolStripLabel1.Text = "Pen Size:";
            // 
            // txtbox_PenWidth
            // 
            this.txtbox_PenWidth.Name = "txtbox_PenWidth";
            this.txtbox_PenWidth.Size = new System.Drawing.Size(120, 40);
            this.txtbox_PenWidth.TextChanged += new System.EventHandler(this.txtbox_PenWidth_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(20, 1);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(62, 37);
            this.toolStripLabel2.Text = "Pen Color:";
            // 
            // combo_PenColor
            // 
            this.combo_PenColor.Name = "combo_PenColor";
            this.combo_PenColor.Size = new System.Drawing.Size(120, 40);
            this.combo_PenColor.SelectedIndexChanged += new System.EventHandler(this.combo_PenColor_SelectedIndexChanged);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.AutoSize = false;
            this.toolStripSeparator6.BackColor = System.Drawing.Color.Transparent;
            this.toolStripSeparator6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(20, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(106, 37);
            this.toolStripLabel4.Text = "Background Color:";
            // 
            // combo_BackgroundColor
            // 
            this.combo_BackgroundColor.Name = "combo_BackgroundColor";
            this.combo_BackgroundColor.Size = new System.Drawing.Size(120, 40);
            this.combo_BackgroundColor.SelectedIndexChanged += new System.EventHandler(this.combo_BackgroundColor_SelectedIndexChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1016, 740);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel_PaintCanvas);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.Name = "mainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subliminal Paint v0.01";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ToolStripButton btn_NewCanvas;

        private System.Windows.Forms.ToolStripComboBox combo_BackgroundColor;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

        private System.Windows.Forms.ToolStripButton btn_SaveBitmap;

        private System.Windows.Forms.ToolStripLabel toolStripLabel2;

        private System.Windows.Forms.ToolStripComboBox combo_PenColor;

        private System.Windows.Forms.ToolStripLabel toolStripLabel1;

        private System.Windows.Forms.ToolStripTextBox txtbox_PenWidth;

        private System.Windows.Forms.ToolStrip toolStrip1;

        private System.Windows.Forms.Panel panel_PaintCanvas;

        #endregion
    }
}