using task3.Abstractions;
using task3.Interfaces;

namespace task3.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer) : base(renderer) { }

        public override void Draw()
        {
            renderer.Render("Triangle");
        }
    }
}
