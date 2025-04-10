using task4.Interfaces;
using task4.TextHandler;

public class Program
{
    public static void Main()
    {
        string testFile = "test.txt";
        string restrictedFile = "secret.txt";

        File.WriteAllText(testFile, "Hello\nWorld");
        File.WriteAllText(restrictedFile, "Top secret\nData");

        Console.WriteLine("=== SmartTextChecker ===");
        ISmartTextReader checker = new SmartTextChecker();
        checker.ReadText(testFile);

        Console.WriteLine("\n=== SmartTextReaderLocker ===");
        ISmartTextReader locker = new SmartTextReaderLocker(".*secret.*");
        locker.ReadText(testFile);      
        locker.ReadText(restrictedFile);
    }
}