using mkr_1.Enums;
using mkr_1.Nodes;

public class Program
{
    public static void Main()
    {
        var ul = new LoggingElementNode("ul", DisplayType.Block, TagType.Paired);
        ul.AddCssClass("list");

        var li = new LoggingElementNode("li", DisplayType.Block, TagType.Paired);
        li.AddChild(new LightTextNode("Item 1"));

        ul.AddChild(li);
        ul.RemoveChild(li);

        Console.WriteLine(ul.OuterHTML);

        for (int i = 1; i <= 3; i++)
        {
            var text = new LightTextNode($"Item {i}");
            li.Children.Add(text);
            ul.Children.Add(li);
        }

        var iterator = new LightNodeIterator(ul);

        Console.WriteLine("DFS:");
        foreach (var node in iterator.TraverseDepthFirst())
        {
            Console.WriteLine($" - {node.GetType().Name}");
        }

        Console.WriteLine("\nBFS:");
        foreach (var node in iterator.TraverseBreadthFirst())
        {
            Console.WriteLine($" - {node.GetType().Name}");
        }
    }
}