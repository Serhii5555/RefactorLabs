using task4.Strategies;
using task4.Enums;

namespace task4
{
    public class ImageNode : LightElementNode
    {
        private readonly IImageLoadStrategy _loadStrategy;
        public string Href { get; }

        public ImageNode(string href, IImageLoadStrategy strategy)
            : base("img", DisplayType.Inline, TagType.Single)
        {
            Href = href;
            _loadStrategy = strategy;
        }

        public override string OuterHTML
        {
            get
            {
                string src = _loadStrategy.Load(Href);
                return $"<img src=\"{Href}\" alt=\"{src}\" />";
            }
        }

        public override string InnerHTML => "";
    }
}
