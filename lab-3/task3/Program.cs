using task3.Abstractions;
using task3.Interfaces;
using task3.Renderers;
using task3.Shapes;

public class Program
{
    public static void Main()
    {
        IRenderer vector = new VectorRenderer();
        IRenderer raster = new RasterRenderer();

        Shape circle = new Circle(vector);
        Shape square = new Square(raster);
        Shape triangle = new Triangle(vector);

        circle.Draw();    
        square.Draw(); 
        triangle.Draw();  
    }
}