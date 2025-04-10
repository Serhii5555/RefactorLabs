using System.Text;
using task5.Enums;

namespace task5
{
    public class LightElementNode : LightNode
    {
        public TagFlyweight Flyweight { get; }
        public List<string> CssClasses { get; set; }
        public List<LightNode> Children { get; set; }

        public LightElementNode(TagFlyweight flyweight)
        {
            Flyweight = flyweight;
            CssClasses = new List<string>();
            Children = new List<LightNode>();
        }

        public override string InnerHTML
        {
            get
            {
                var sb = new StringBuilder();
                foreach (var child in Children)
                    sb.Append(child.OuterHTML);
                return sb.ToString();
            }
        }

        public override string OuterHTML
        {
            get
            {
                string classAttr = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";
                if (Flyweight.ClosingType == TagType.Single)
                    return $"<{Flyweight.TagName}{classAttr}/>";
                else
                    return $"<{Flyweight.TagName}{classAttr}>{InnerHTML}</{Flyweight.TagName}>";
            }
        }
    }
}
