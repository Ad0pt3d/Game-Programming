using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GraphicLibrary
{
    public class GraphicLine : GraphicShape
    {
        Point startPt, endPt;

        public Point StartPt
        {
            get { return startPt; }
            set { startPt = value; }
        }

        public Point EndPt
        {
            get { return endPt; }
            set { endPt = value; }
        }
        
        public GraphicLine(Color lineColor, float lineWidth)
        {
            base.LineWidth = lineWidth;
            base.LineColor = lineColor;
        }

        public GraphicLine(Point startPt, Point endPt, Color lineColor, float lineWidth)
        {
            this.startPt = startPt;
            this.endPt = endPt;
            base.LineWidth = lineWidth;
            base.LineColor = lineColor;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new(LineColor, LineWidth))
            {
                g.DrawLine(pen, startPt, endPt);
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
