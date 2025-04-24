namespace task4.Strategies
{
    public class FileImageLoadStrategy : IImageLoadStrategy
    {
        public string Load(string href)
        {
            return File.Exists(href) ? $"[Loaded from file: {href}]" : "[File not found]";
        }
    }
}
