using mkr_1.Nodes;
using mkr_1.Interfaces;

namespace mkr_1.Commands
{
    public class AddClassCommand : ICommand
    {
        private readonly LightElementNode element;
        private readonly string className;

        public AddClassCommand(LightElementNode element, string className)
        {
            this.element = element;
            this.className = className;
        }
        
        public void Execute()
        {
            element.CssClasses.Add(className);
            element.OnClassListApplied(); 
        }
    }

}
