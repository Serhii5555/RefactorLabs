using task5;
using task5.Enums;

public class Program
{
    public static void Main()
    {
        // Створення списку <ul>
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
    }
}