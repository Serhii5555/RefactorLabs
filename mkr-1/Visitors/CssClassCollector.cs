using mkr_1.Interfaces;
using mkr_1.Nodes; 

namespace mkr_1.Visitors
{
    public class CssClassCollector : ILightNodeVisitor
    {
        public HashSet<string> Classes { get; } = new();

        public void VisitElement(LightElementNode element)
        {
            foreach (var css in element.CssClasses)
            {
                Classes.Add(css);
            }
        }

        public void VisitText(LightTextNode textNode)
        {
        }
    }

}
