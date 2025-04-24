using System.Text;
using task3.Enums;
using task3.Enums;

namespace task3
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; set; }
        public DisplayType Display { get; set; }
        public TagType TagClosingType { get; set; }
        public List<string> CssClasses { get; set; }
        public List<LightNode> Children { get; set; }

        private Dictionary<EventType, List<Action>> eventListeners;

        public LightElementNode(string tagName, DisplayType display, TagType closingType)
        {
            TagName = tagName;
            Display = display;
            TagClosingType = closingType;
            CssClasses = new List<string>();
            Children = new List<LightNode>();
            eventListeners = new Dictionary<EventType, List<Action>>();
        }

        public void AddEventListener(EventType eventType, Action callback)
        {
            if (!eventListeners.ContainsKey(eventType))
                eventListeners[eventType] = new List<Action>();

            eventListeners[eventType].Add(callback);
        }

        public void TriggerEvent(EventType eventType)
        {
            if (eventListeners.ContainsKey(eventType))
            {
                foreach (var callback in eventListeners[eventType])
                    callback();
            }
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
