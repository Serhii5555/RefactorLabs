using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class History
    {
        private Stack<TextDocumentMemento> _mementos = new Stack<TextDocumentMemento>();

        public void Push(TextDocumentMemento memento)
        {
            _mementos.Push(memento);
        }

        public TextDocumentMemento Pop()
        {
            return _mementos.Pop();
        }
    }

}
