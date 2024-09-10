namespace Drawing.net
{
    public partial class DrawingMainForm : Form
    {
        private Color shapeColor = Color.Red;

        public DrawingMainForm()
        {
            InitializeComponent();
            comboBoxLineWidth.SelectedIndex = 1;
        }

        private void btn_DrawLine_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelShape.Text = "Drawing Line";
        }

        private void btn_DrawPolyline_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelShape.Text = "Drawing Polyline";
        }

        private void btn_DrawEllipse_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelShape.Text = "Drawing Ellipse";
        }

        private void btn_DrawRectangle_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelShape.Text = "Drawing Rectangle";
        }

        private void btn_DrawPolygon_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelShape.Text = "Drawing Polygon";
        }

        private void btn_ColorPicker_Click(object sender, EventArgs e)
        {
            if (lineColorPicker.ShowDialog() == DialogResult.OK)
            {

                shapeColor = lineColorPicker.Color;

                toolStripStatusLabelColor.Text = lineColorPicker.Color.ToString();
                toolStripStatusLabelColor.BackColor = lineColorPicker.Color;
            }
        }

        private void comboBoxLineWidth_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelLineWidth.Text = $"Line Width: {comboBoxLineWidth.SelectedText}";
        }
    }
}
