using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicLibrary
{
    public class GraphicRectangle : GraphicShape
    {
        Point topLeft, bottomRight;

        public Point TopLeft
        {
            get { return topLeft; }
            set { topLeft = value; }
        }

        public Point BottomRight
        {
            get { return bottomRight; }
            set { bottomRight = value; }
        }

        public GraphicRectangle(Color lineColor, float lineWidth)
        {
            base.LineWidth = lineWidth;
            base.LineColor = lineColor;
        }

        public GraphicRectangle(Point startPt, Point endPt, Color lineColor, float lineWidth)
        {
            this.topLeft = startPt;
            this.bottomRight = endPt;
            base.LineWidth = lineWidth;
            base.LineColor = lineColor;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new(LineColor, LineWidth))
            {
                g.DrawRectangle(pen, GetRect());
            }
        }

        public override string Serialize()
        {
            throw new NotImplementedException();
        }

        public override void Deserialize(string record)
        {
            throw new NotImplementedException();
        }

        private RectangleF GetRect()
        {
            RectangleF rect = new RectangleF();

            rect.X = Math.Min(topLeft.X, bottomRight.X);
            rect.Y = Math.Min(topLeft.Y, bottomRight.Y);

            rect.Width = Math.Abs(topLeft.X - bottomRight.X);
            rect.Height = Math.Abs(topLeft.Y - bottomRight.Y);

            return rect;
        }
    }
}
