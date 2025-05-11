using System.Text;
using mkr_1.Enums;

namespace mkr_1.Nodes
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; set; }
        public DisplayType Display { get; set; }
        public TagType TagClosingType { get; set; }
        public List<string> CssClasses { get; set; }
        public List<LightNode> Children { get; set; }

        public LightElementNode(string tagName, DisplayType display, TagType closingType)
        {
            TagName = tagName;
            Display = display;
            TagClosingType = closingType;
            CssClasses = new List<string>();
            Children = new List<LightNode>();

            OnCreated(); 
        }

        public void AddChild(LightNode node)
        {
            Children.Add(node);
            node.OnInserted(); 
        }

        public void RemoveChild(LightNode node)
        {
            if (Children.Remove(node))
            {
                node.OnRemoved(); 
            }
        }

        public void AddCssClass(string cssClass)
        {
            CssClasses.Add(cssClass);
            OnClassListApplied();
        }

        public override string InnerHTML
        {
            get
            {
                var sb = new StringBuilder();
                foreach (var child in Children)
                {
                    sb.Append(child.OuterHTML);
                }
                return sb.ToString();
            }
        }

        public override string OuterHTML
        {
            get
            {
                var classAttribute = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";
                if (TagClosingType == TagType.Single)
                {
                    return $"<{TagName}{classAttribute}/>";
                }
                else
                {
                    return $"<{TagName}{classAttribute}>{InnerHTML}</{TagName}>";
                }
            }
        }

        public int ChildrenCount => Children.Count;
    }

}
