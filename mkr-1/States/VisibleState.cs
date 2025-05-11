using mkr_1.Interfaces;
using mkr_1.Nodes;

namespace mkr_1.States
{
    public class VisibleState : IElementState
    {
        public string Render(LightElementNode element)
        {
            return element.RenderAsHtml();
        }
    }
}
