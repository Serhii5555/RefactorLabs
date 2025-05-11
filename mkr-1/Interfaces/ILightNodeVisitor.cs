using mkr_1.Nodes;

namespace mkr_1.Interfaces
{
    public interface ILightNodeVisitor
    {
        void VisitElement(LightElementNode element);
        void VisitText(LightTextNode textNode);
    }
}
