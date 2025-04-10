using task3.Abstractions;
using task3.Interfaces;

namespace task3.Shapes
{
    public class Circle : Shape
    {
        public Circle(IRenderer renderer) : base(renderer) { }

        public override void Draw()
        {
            renderer.Render("Circle");
        }
    }
}
