using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class TextEditor
    {
        private TextDocument _document;

        public TextEditor()
        {
            _document = new TextDocument();
        }

        public void Write(string text)
        {
            _document.SetContent(text);
        }

        public string Read()
        {
            return _document.ToString();
        }

        public TextDocumentMemento Save()
        {
            return new TextDocumentMemento(_document.Content);
        }

        public void Restore(TextDocumentMemento memento)
        {
            _document.SetContent(memento.State);
        }
    }
}
