using mkr_1.Nodes;
using mkr_1.Interfaces;

namespace mkr_1.Commands
{
    public class ReplaceTextCommand : ICommand
    {
        private readonly LightTextNode textNode;
        private readonly string newText;

        public ReplaceTextCommand(LightTextNode textNode, string newText)
        {
            this.textNode = textNode;
            this.newText = newText;
        }

        public void Execute()
        {
            textNode.SetText(newText);
            textNode.OnTextRendered(); 
        }
    }

}
