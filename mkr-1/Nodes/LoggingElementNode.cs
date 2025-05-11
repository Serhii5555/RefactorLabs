using mkr_1.Enums;

namespace mkr_1.Nodes
{
    public class LoggingElementNode : LightElementNode
    {
        public LoggingElementNode(string tag, DisplayType display, TagType type)
            : base(tag, display, type) { }

        public override void OnCreated()
        {
            Console.WriteLine($"[Hook] Element <{TagName}> created.");
        }

        public override void OnInserted()
        {
            Console.WriteLine($"[Hook] <{TagName}> inserted into parent.");
        }

        public override void OnRemoved()
        {
            Console.WriteLine($"[Hook] <{TagName}> removed from parent.");
        }

        public override void OnClassListApplied()
        {
            Console.WriteLine($"[Hook] Class list changed for <{TagName}>.");
        }
    }

}
