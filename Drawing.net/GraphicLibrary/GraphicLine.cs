using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicLibrary
{
    class GraphicLine : GraphicShape
    {
        Point startPoint;
        Point endPoint;
        
        public Point StartPoint
        {
            get { return startPoint; }
            set { startPoint = value; }
        }

        public Point EndPoint
        {
            get { return endPoint; }
            set { endPoint = value; }
        }

        GraphicLine() { }

        GraphicLine(Color lineColor, float lineWidth) { }

        GraphicLine(Point startPoint, Point endPoint, Color lineColor, float lineWidth) { }        
    }
}
