using task4.Interfaces;

namespace task4.TextHandler
{
    public class SmartTextChecker : ISmartTextReader
    {
        private SmartTextReader reader = new SmartTextReader();

        public char[][] ReadText(string path)
        {
            Console.WriteLine($"[LOG] Opening file: {path}");
            try
            {
                char[][] data = reader.ReadText(path);
                int lineCount = data.Length;
                int charCount = 0;
                foreach (var line in data)
                    charCount += line.Length;

                Console.WriteLine($"[LOG] Read successful. Lines: {lineCount}, Characters: {charCount}");
                Console.WriteLine($"[LOG] Closing file: {path}");
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] {ex.Message}");
                return new char[0][];
            }
        }
    }
}
