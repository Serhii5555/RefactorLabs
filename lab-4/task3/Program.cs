using task3.Enums;
using task3;

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

            int index = i; 
            li.AddEventListener(EventType.Click, () =>
            {
                Console.WriteLine($"List item {index} clicked!");
            });

            ul.Children.Add(li);
        }

        Console.WriteLine("OuterHTML:");
        Console.WriteLine(ul.OuterHTML);

        Console.WriteLine("\nInnerHTML:");
        Console.WriteLine(ul.InnerHTML);

        Console.WriteLine($"\nChild count: {ul.ChildrenCount}");

        Console.WriteLine("\nTriggering click events:");
        foreach (var child in ul.Children)
        {
            if (child is LightElementNode el)
            {
                el.TriggerEvent(EventType.Click);
            }
        }
    }
}
