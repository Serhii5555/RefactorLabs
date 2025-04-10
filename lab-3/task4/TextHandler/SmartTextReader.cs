using task4.Interfaces;

namespace task4.TextHandler
{
    public class SmartTextReader : ISmartTextReader
    {
        public char[][] ReadText(string path)
        {
            string[] lines = File.ReadAllLines(path);
            char[][] result = new char[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                result[i] = lines[i].ToCharArray();
            }
            return result;
        }
    }
}
