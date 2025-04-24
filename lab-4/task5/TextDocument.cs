using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class TextDocument
    {
        public string Content { get; private set; }

        public TextDocument(string content = "")
        {
            Content = content;
        }

        public void SetContent(string content)
        {
            Content = content;
        }

        public override string ToString()
        {
            return Content;
        }
    }
}
