using System.Drawing;

namespace GraphicLibrary
{
    public abstract class GraphicShape
    {
        public Color lineColor;
        public float lineWidth;

        public GraphicShape() { }

        public GraphicShape(Color lineColor, float lineWidth) { }

        public void Draw(Graphics g) { }

        public void Serialize() { }

        public void Deserialize(string record) { }
    }
}
