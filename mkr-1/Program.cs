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
    }
}