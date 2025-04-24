using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class TextDocumentMemento
    {
        public string State { get; }

        public TextDocumentMemento(string state)
        {
            State = state;
        }
    }
}
