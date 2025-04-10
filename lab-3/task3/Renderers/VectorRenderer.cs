using task3.Interfaces;

namespace task3.Renderers
{
    public class VectorRenderer : IRenderer
    {
        public void Render(string shapeName)
        {
            Console.WriteLine($"Drawing {shapeName} as lines (vector)");
        }
    }
}
