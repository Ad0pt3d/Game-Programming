using GraphicLibrary;
using GraphicManager;
using System.Diagnostics;

namespace Drawing.net
{
    public partial class DrawingMainForm : Form
    {
        private Color lineColor = Color.Red;
        private int lineWidth = 2;


        public enum DrawingMode
        {
            None,
            Line,
            Polyline,
            Circle,
            Ellipse,
            Rectangle,
            Polygon
        }

        GraphicObjectManager graphicObjectManager = new GraphicObjectManager();

        private DrawingMode drawingMode;
        private bool isMouseDown = false;
        private GraphicShape? shape = null;

        public DrawingMainForm()
        {
            InitializeComponent();
            comboBoxLineWidth.SelectedIndex = 1;
        }

        private void btn_DrawLine_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelShape.Text = "Drawing Line";
            drawingMode = DrawingMode.Line;
            shape = new GraphicLine(lineColor, lineWidth);
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

                lineColor = lineColorPicker.Color;

                toolStripStatusLabelColor.Text = lineColorPicker.Color.ToString();
                toolStripStatusLabelColor.BackColor = lineColorPicker.Color;

                CreateNewDrawingObject();
            }
        }

        private void comboBoxLineWidth_DropDownClosed(object sender, EventArgs e)
        {
            toolStripStatusLabelLineWidth.Text = comboBoxLineWidth.SelectedText;
        }

        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            if (shape != null)
            {
                switch (drawingMode)
                {
                    case DrawingMode.Line:
                        ((GraphicLine)shape).StartPt = e.Location;
                        break;
                }
            }
        }

        private void panelCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouseDown)
            {
                return;
            }

            if (shape != null)
            {
                switch (drawingMode)
                {
                    case DrawingMode.Line:
                        ((GraphicLine)shape).EndPt = e.Location;
                        break;
                }
            }

            panelCanvas.Refresh();


        }

        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                if (shape != null)
                {
                    switch (drawingMode)
                    {
                        case DrawingMode.Line:
                            ((GraphicLine)shape).EndPt = e.Location;
                            panelCanvas.Refresh();
                            graphicObjectManager.AddGraphicShape(shape);
                            isMouseDown = false;

                            CreateNewDrawingObject();
                            break;
                    }
                }
            }
        }

        private void CreateNewDrawingObject()
        {
            switch (drawingMode)
            {
                case DrawingMode.Line:
                    shape = new GraphicLine(lineColor, lineWidth);
                    break;
            }
        }

        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (graphicObjectManager.GraphicShapes.Count > 0)
            {
                foreach (GraphicShape shape in graphicObjectManager.GraphicShapes)
                {
                    shape.Draw(e.Graphics);
                }
            }

            if (!isMouseDown)
            {
                return;
            }

            if (shape != null)
            {
                switch (drawingMode)
                {
                    case DrawingMode.Line:
                        shape.Draw(e.Graphics);
                        break;
                }
            }

        }

        private void comboBoxLineWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            lineWidth = comboBoxLineWidth.SelectedIndex + 1;
            toolStripStatusLabelLineWidth.Text = $"Line Width: {comboBoxLineWidth.SelectedIndex + 1} px";
            CreateNewDrawingObject();
        }
    }
}
