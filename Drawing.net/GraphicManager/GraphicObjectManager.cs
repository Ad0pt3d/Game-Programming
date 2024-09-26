using GraphicLibrary;

namespace GraphicManager
{
    public class GraphicObjectManager
    {
        private const string FILE_NAME = "Shapes.json";
        private List<GraphicShape> graphicShapes = new List<GraphicShape>();

        public List<GraphicShape> GraphicShapes
        {
            get { return graphicShapes; }
            set { graphicShapes = value; }
        }

        public GraphicObjectManager() { }

        public void AddGraphicShape(GraphicShape shape)
        {
            graphicShapes.Add(shape);
        }


        public void RemoveGraphicShape(GraphicShape shape)
        {
            graphicShapes.Remove(shape);
        }

        public void RemoveLastShape()
        {
            graphicShapes.RemoveAt(graphicShapes.Count - 1);
        }

        public void Clear()
        {
            graphicShapes.Clear();
        }

    }
}
