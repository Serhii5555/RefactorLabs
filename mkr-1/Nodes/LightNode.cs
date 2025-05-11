namespace mkr_1.Nodes
{
    public abstract class LightNode
    {
        public virtual void OnCreated() { }
        public virtual void OnInserted() { }
        public virtual void OnRemoved() { }
        public virtual void OnClassListApplied() { }
        public virtual void OnTextRendered() { }

        public abstract string OuterHTML { get; }
        public abstract string InnerHTML { get; }
    }
}
