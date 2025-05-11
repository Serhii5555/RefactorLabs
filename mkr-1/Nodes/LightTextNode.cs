namespace mkr_1.Nodes
{
    public class LightTextNode : LightNode
    {
        private string text;
        public LightTextNode(string text)
        {
            this.text = text;
            OnCreated();
        }

        public void SetText(string newText)
        {
            text = newText;
        }

        public override string OuterHTML
        {
            get
            {
                OnTextRendered();   
                return text;
            }
        }

        public override string InnerHTML => OuterHTML;
    }

}
