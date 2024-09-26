using System.Drawing;

namespace GraphicLibrary
{
    public abstract class GraphicShape
    {
        public Color LineColor { get; set; }
        public float LineWidth { get; set; }
        public Rectangle Bounds { get; set; }

        public GraphicShape() { }

        public GraphicShape(Color lineColor, float lineWidth) { }

        public abstract void Draw(Graphics g);

        public abstract string Serialize();

        public abstract void Deserialize(string record);
    }
}
