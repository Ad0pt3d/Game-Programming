using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicLibrary
{
    public class GraphicPolyline : GraphicShape
    {
        List<Point> points = new List<Point>();

        public List<Point> Points
        {
            get { return points; }
            private set { points = value; }
        }

        public GraphicPolyline(Color lineColor, float lineWidth)
        {
            base.LineWidth = lineWidth;
            base.LineColor = lineColor;
        }

        public void AddPoint(Point point)
        {
            this.points.Add(point);
        }

        public void ReplacePoint(Point point)
        {
            this.points[points.Count - 1] = point;
        }

        public override void Draw(Graphics g)
        {
            if (points.Count < 2) return;

            using (Pen pen = new(LineColor))
            {
                g.DrawLines(pen, points.ToArray<Point>());
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
    }
}
