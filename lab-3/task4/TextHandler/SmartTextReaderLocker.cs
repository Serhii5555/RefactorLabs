using System.Text.RegularExpressions;
using task4.Interfaces;

namespace task4.TextHandler
{
    public class SmartTextReaderLocker : ISmartTextReader
    {
        private SmartTextReader reader = new SmartTextReader();
        private Regex restrictedPattern;

        public SmartTextReaderLocker(string pattern)
        {
            restrictedPattern = new Regex(pattern);
        }

        public char[][] ReadText(string path)
        {
            if (restrictedPattern.IsMatch(path))
            {
                Console.WriteLine("Access denied!");
                return new char[0][];
            }
            else
            {
                return reader.ReadText(path);
            }
        }
    }

}
