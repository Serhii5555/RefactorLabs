using task3.Abstractions;
using task3.Interfaces;

namespace task3.Shapes
{
    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer) { }

        public override void Draw()
        {
            renderer.Render("Square");
        }
    }
}
