using task5.Enums;
using task5;

public class Program
{
    public static void Main()
    {
        string[] bookLines = new[]
        {
            "The Great Adventure",
            "Chapter One",
            "    It was a dark and stormy night.",
            "The rain fell in torrents—except at occasional intervals,",
            "when it was checked by a violent gust of wind which swept up the streets.",
            "Chapter Two",
            "    Again came the storm, louder and fiercer."
        };

        var factory = new TagFlyweightFactory();
        var root = new LightElementNode(factory.GetFlyweight("div", DisplayType.Block, TagType.Paired));

        foreach (var line in bookLines)
        {
            LightElementNode element;
            if (bookLines[0] == line)
                element = new LightElementNode(factory.GetFlyweight("h1", DisplayType.Block, TagType.Paired));
            else if (line.Length < 20)
                element = new LightElementNode(factory.GetFlyweight("h2", DisplayType.Block, TagType.Paired));
            else if (line.StartsWith(" "))
                element = new LightElementNode(factory.GetFlyweight("blockquote", DisplayType.Block, TagType.Paired));
            else
                element = new LightElementNode(factory.GetFlyweight("p", DisplayType.Block, TagType.Paired));

            element.Children.Add(new LightTextNode(line.Trim()));
            root.Children.Add(element);
        }

        Console.WriteLine(root.OuterHTML);
        Console.WriteLine($"\nTotal flyweight tags created: {factory.Count}");

        long memoryUsed = GC.GetTotalMemory(true);
        Console.WriteLine($"Estimated memory used: {memoryUsed / 1024.0:F2} KB");
    }
}
