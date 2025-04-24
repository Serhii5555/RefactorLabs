namespace task4.Strategies
{
    public class NetworkImageLoadStrategy : IImageLoadStrategy
    {
        public string Load(string href)
        {
            return href.StartsWith("http") ? $"[Loaded from network: {href}]" : "[Invalid network URL]";
        }
    }
}
