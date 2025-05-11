using mkr_1.Commands;
using mkr_1.Enums;
using mkr_1.Nodes;
using mkr_1.States;

public class Program
{
    public static void Main()
    {
        // task1
        var ul = new LoggingElementNode("ul", DisplayType.Block, TagType.Paired);
        ul.AddCssClass("list");

        var li = new LoggingElementNode("li", DisplayType.Block, TagType.Paired);
        li.AddChild(new LightTextNode("Item 1"));

        ul.AddChild(li);
        ul.RemoveChild(li);

        Console.WriteLine(ul.OuterHTML);

        // task2
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

        // task3
        var textNode = new LightTextNode("Old Text");
        li.Children.Add(textNode);

        var addClass = new AddClassCommand(li, "highlighted");
        var changeText = new ReplaceTextCommand(textNode, "New Text");

        addClass.Execute();
        changeText.Execute();

        Console.WriteLine(li.OuterHTML);

        //task4
        var div = new LightElementNode("div", DisplayType.Block, TagType.Paired);
        div.AddCssClass("box");
        div.Children.Add(new LightTextNode("Hello!"));

        Console.WriteLine("Default (Visible):");
        Console.WriteLine(div.OuterHTML);

        div.SetState(new HiddenState());
        Console.WriteLine("\nHidden:");
        Console.WriteLine(div.OuterHTML);

        div.SetState(new DisabledState());
        Console.WriteLine("\nDisabled:");
        Console.WriteLine(div.OuterHTML);

    }
}