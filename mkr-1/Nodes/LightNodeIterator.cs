namespace mkr_1.Nodes
{
    public class LightNodeIterator
    {
        private readonly LightNode root;

        public LightNodeIterator(LightNode root)
        {
            this.root = root;
        }

        public IEnumerable<LightNode> TraverseDepthFirst()
        {
            var stack = new Stack<LightNode>();
            stack.Push(root);

            while (stack.Any())
            {
                var current = stack.Pop();
                yield return current;

                if (current is LightElementNode element)
                {
                    for (int i = element.Children.Count - 1; i >= 0; i--)
                    {
                        stack.Push(element.Children[i]);
                    }
                }
            }
        }

        public IEnumerable<LightNode> TraverseBreadthFirst()
        {
            var queue = new Queue<LightNode>();
            queue.Enqueue(root);

            while (queue.Any())
            {
                var current = queue.Dequeue();
                yield return current;

                if (current is LightElementNode element)
                {
                    foreach (var child in element.Children)
                    {
                        queue.Enqueue(child);
                    }
                }
            }
        }
    }

}
