using task4.Strategies;
using task4;
using task4.Enums;

public class Program
{
    public static void Main()
    {
        var ul = new LightElementNode("ul", DisplayType.Block, TagType.Paired);
        ul.CssClasses.Add("my-list");

        for (int i = 1; i <= 3; i++)
        {
            var li = new LightElementNode("li", DisplayType.Block, TagType.Paired);
            li.Children.Add(new LightTextNode($"Item {i}"));
            ul.Children.Add(li);
        }

        Console.WriteLine("OuterHTML:");
        Console.WriteLine(ul.OuterHTML);

        Console.WriteLine("\nInnerHTML:");
        Console.WriteLine(ul.InnerHTML);

        Console.WriteLine($"\nChild count: {ul.ChildrenCount}");

        Console.WriteLine("\n--- ImageNode Tests ---");
        var image1 = new ImageNode("C:\\images\\example.jpg", new FileImageLoadStrategy());
        var image2 = new ImageNode("https://example.com/image.png", new NetworkImageLoadStrategy());

        Console.WriteLine(image1.OuterHTML);
        Console.WriteLine(image2.OuterHTML);
    }
}
