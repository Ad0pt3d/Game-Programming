using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicLibrary
{
    public class GraphicPolygon : GraphicShape
    {
        List<Point> points = new List<Point>();

        public List<Point> Points
        {
            get { return points; }
            private set { points = value; }
        }

        public GraphicPolygon(Color lineColor, float lineWidth)
        {
            base.LineWidth = lineWidth;
            base.LineColor = lineColor;
        }

        public void AddPoint(Point point)
        {
            this.points.Add(point);
        }

        public void RemovePoint(Point point)
        {
            this.points[Points.Count - 1] = point;
        }

        public override void Draw(Graphics g)
        {
            if (points.Count < 2) return;

            using (Pen pen = new (LineColor, LineWidth))
            {
                g.DrawPolygon(pen, points.ToArray<Point>());
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
