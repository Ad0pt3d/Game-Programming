namespace Drawing.net
{
    partial class DrawingMainForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingMainForm));
            toolStripToolbar = new ToolStrip();
            btn_NewCanvas = new ToolStripButton();
            btn_FileOpen = new ToolStripButton();
            btn_FileSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btn_DrawLine = new ToolStripButton();
            btn_DrawPolyline = new ToolStripButton();
            btn_DrawEllipse = new ToolStripButton();
            btn_DrawRectangle = new ToolStripButton();
            btn_DrawPolygon = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btn_ColorPicker = new ToolStripButton();
            comboBoxLineWidth = new ToolStripComboBox();
            statusStripLabels = new StatusStrip();
            toolStripStatusLabelShape = new ToolStripStatusLabel();
            toolStripStatusLabelColor = new ToolStripStatusLabel();
            toolStripStatusLabelLineWidth = new ToolStripStatusLabel();
            panelCanvas = new Panel();
            lineColorPicker = new ColorDialog();
            toolStripToolbar.SuspendLayout();
            statusStripLabels.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripToolbar
            // 
            toolStripToolbar.ImageScalingSize = new Size(20, 20);
            toolStripToolbar.Items.AddRange(new ToolStripItem[] { btn_NewCanvas, btn_FileOpen, btn_FileSave, toolStripSeparator1, btn_DrawLine, btn_DrawPolyline, btn_DrawEllipse, btn_DrawRectangle, btn_DrawPolygon, toolStripSeparator2, btn_ColorPicker, comboBoxLineWidth });
            toolStripToolbar.Location = new Point(0, 0);
            toolStripToolbar.Name = "toolStripToolbar";
            toolStripToolbar.Size = new Size(800, 28);
            toolStripToolbar.TabIndex = 0;
            toolStripToolbar.Text = "toolStripToolbar";
            // 
            // btn_NewCanvas
            // 
            btn_NewCanvas.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_NewCanvas.Image = (Image)resources.GetObject("btn_NewCanvas.Image");
            btn_NewCanvas.ImageTransparentColor = Color.Magenta;
            btn_NewCanvas.Name = "btn_NewCanvas";
            btn_NewCanvas.Size = new Size(29, 25);
            btn_NewCanvas.Text = "New Canvas";
            // 
            // btn_FileOpen
            // 
            btn_FileOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_FileOpen.Image = (Image)resources.GetObject("btn_FileOpen.Image");
            btn_FileOpen.ImageTransparentColor = Color.Magenta;
            btn_FileOpen.Name = "btn_FileOpen";
            btn_FileOpen.Size = new Size(29, 25);
            btn_FileOpen.Text = "Open File";
            // 
            // btn_FileSave
            // 
            btn_FileSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_FileSave.Image = (Image)resources.GetObject("btn_FileSave.Image");
            btn_FileSave.ImageTransparentColor = Color.Magenta;
            btn_FileSave.Name = "btn_FileSave";
            btn_FileSave.Size = new Size(29, 25);
            btn_FileSave.Text = "Save File";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // btn_DrawLine
            // 
            btn_DrawLine.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_DrawLine.Image = (Image)resources.GetObject("btn_DrawLine.Image");
            btn_DrawLine.ImageTransparentColor = Color.Magenta;
            btn_DrawLine.Name = "btn_DrawLine";
            btn_DrawLine.Size = new Size(29, 25);
            btn_DrawLine.Text = "Draw Line";
            btn_DrawLine.Click += btn_DrawLine_Click;
            // 
            // btn_DrawPolyline
            // 
            btn_DrawPolyline.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_DrawPolyline.Image = (Image)resources.GetObject("btn_DrawPolyline.Image");
            btn_DrawPolyline.ImageTransparentColor = Color.Magenta;
            btn_DrawPolyline.Name = "btn_DrawPolyline";
            btn_DrawPolyline.Size = new Size(29, 25);
            btn_DrawPolyline.Text = "Draw Polyline";
            btn_DrawPolyline.Click += btn_DrawPolyline_Click;
            // 
            // btn_DrawEllipse
            // 
            btn_DrawEllipse.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_DrawEllipse.Image = (Image)resources.GetObject("btn_DrawEllipse.Image");
            btn_DrawEllipse.ImageTransparentColor = Color.Magenta;
            btn_DrawEllipse.Name = "btn_DrawEllipse";
            btn_DrawEllipse.Size = new Size(29, 25);
            btn_DrawEllipse.Text = "Draw Ellipse";
            btn_DrawEllipse.Click += btn_DrawEllipse_Click;
            // 
            // btn_DrawRectangle
            // 
            btn_DrawRectangle.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_DrawRectangle.Image = (Image)resources.GetObject("btn_DrawRectangle.Image");
            btn_DrawRectangle.ImageTransparentColor = Color.Magenta;
            btn_DrawRectangle.Name = "btn_DrawRectangle";
            btn_DrawRectangle.Size = new Size(29, 25);
            btn_DrawRectangle.Text = "Draw Rectangle";
            btn_DrawRectangle.Click += btn_DrawRectangle_Click;
            // 
            // btn_DrawPolygon
            // 
            btn_DrawPolygon.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_DrawPolygon.Image = (Image)resources.GetObject("btn_DrawPolygon.Image");
            btn_DrawPolygon.ImageTransparentColor = Color.Magenta;
            btn_DrawPolygon.Name = "btn_DrawPolygon";
            btn_DrawPolygon.Size = new Size(29, 25);
            btn_DrawPolygon.Text = "Draw Polygon";
            btn_DrawPolygon.Click += btn_DrawPolygon_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // btn_ColorPicker
            // 
            btn_ColorPicker.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_ColorPicker.Image = (Image)resources.GetObject("btn_ColorPicker.Image");
            btn_ColorPicker.ImageTransparentColor = Color.Magenta;
            btn_ColorPicker.Name = "btn_ColorPicker";
            btn_ColorPicker.Size = new Size(29, 25);
            btn_ColorPicker.Text = "Color Picker";
            btn_ColorPicker.Click += btn_ColorPicker_Click;
            // 
            // comboBoxLineWidth
            // 
            comboBoxLineWidth.Items.AddRange(new object[] { "1 px", "2 px", "3 px", "4 px", "5 px", "6 px", "7 px", "8 px", "9 px", "10 px", "15 px", "20 px" });
            comboBoxLineWidth.Name = "comboBoxLineWidth";
            comboBoxLineWidth.Size = new Size(75, 28);
            comboBoxLineWidth.SelectedIndexChanged += comboBoxLineWidth_TextChanged;
            comboBoxLineWidth.TextChanged += comboBoxLineWidth_TextChanged;
            // 
            // statusStripLabels
            // 
            statusStripLabels.ImageScalingSize = new Size(20, 20);
            statusStripLabels.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelShape, toolStripStatusLabelColor, toolStripStatusLabelLineWidth });
            statusStripLabels.Location = new Point(0, 424);
            statusStripLabels.Name = "statusStripLabels";
            statusStripLabels.Size = new Size(800, 26);
            statusStripLabels.TabIndex = 1;
            statusStripLabels.Text = "statusStrip1";
            // 
            // toolStripStatusLabelShape
            // 
            toolStripStatusLabelShape.AutoSize = false;
            toolStripStatusLabelShape.Name = "toolStripStatusLabelShape";
            toolStripStatusLabelShape.Size = new Size(200, 20);
            toolStripStatusLabelShape.Text = "Drawing Line";
            // 
            // toolStripStatusLabelColor
            // 
            toolStripStatusLabelColor.AutoSize = false;
            toolStripStatusLabelColor.BackColor = Color.Red;
            toolStripStatusLabelColor.Name = "toolStripStatusLabelColor";
            toolStripStatusLabelColor.Size = new Size(200, 20);
            toolStripStatusLabelColor.Text = "Color [Red]";
            // 
            // toolStripStatusLabelLineWidth
            // 
            toolStripStatusLabelLineWidth.AutoSize = false;
            toolStripStatusLabelLineWidth.Name = "toolStripStatusLabelLineWidth";
            toolStripStatusLabelLineWidth.Size = new Size(200, 20);
            toolStripStatusLabelLineWidth.Text = "Line Width: 3 px";
            // 
            // panelCanvas
            // 
            panelCanvas.Dock = DockStyle.Fill;
            panelCanvas.Location = new Point(0, 28);
            panelCanvas.Name = "panelCanvas";
            panelCanvas.Size = new Size(800, 396);
            panelCanvas.TabIndex = 2;
            // 
            // DrawingMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelCanvas);
            Controls.Add(statusStripLabels);
            Controls.Add(toolStripToolbar);
            Name = "DrawingMainForm";
            Text = "DrawingMainForm";
            toolStripToolbar.ResumeLayout(false);
            toolStripToolbar.PerformLayout();
            statusStripLabels.ResumeLayout(false);
            statusStripLabels.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStripToolbar;
        private ToolStripButton btn_NewCanvas;
        private ToolStripButton btn_FileOpen;
        private ToolStripButton btn_DrawLine;
        private ToolStripButton btn_FileSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btn_DrawPolyline;
        private ToolStripButton btn_DrawEllipse;
        private ToolStripButton btn_DrawRectangle;
        private ToolStripButton btn_DrawPolygon;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btn_ColorPicker;
        private ToolStripComboBox comboBoxLineWidth;
        private StatusStrip statusStripLabels;
        private ToolStripStatusLabel toolStripStatusLabelShape;
        private ToolStripStatusLabel toolStripStatusLabelColor;
        private ToolStripStatusLabel toolStripStatusLabelLineWidth;
        private Panel panelCanvas;
        private ColorDialog lineColorPicker;
    }
}
