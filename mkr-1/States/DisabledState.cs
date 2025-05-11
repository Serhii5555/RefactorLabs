using mkr_1.Interfaces;
using mkr_1.Nodes;

namespace mkr_1.States
{
    public class DisabledState : IElementState
    {
        public string Render(LightElementNode element)
        {
            if (!element.CssClasses.Contains("disabled"))
            {
                element.CssClasses.Add("disabled");
            }
            return element.RenderAsHtml();
        }
    }
}
