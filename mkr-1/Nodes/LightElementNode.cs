using System.Text;
using mkr_1.Enums;
using mkr_1.Interfaces;
using mkr_1.States;

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

        private IElementState state = new VisibleState(); 

        public void SetState(IElementState newState)
        {
            state = newState;
        }

        public override string OuterHTML => state.Render(this);

        public string RenderAsHtml()
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

        public override void Accept(ILightNodeVisitor visitor)
        {
            visitor.VisitElement(this);
            foreach (var child in Children)
            {
                child.Accept(visitor);
            }
        }
    }

}
