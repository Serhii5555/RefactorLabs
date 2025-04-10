class Program
{
    static void Main(string[] args)
    {
        string filePath = "log.txt";

        FileLoggerAdapter fileLogger = new FileLoggerAdapter(filePath);

        fileLogger.Log("This is a log message.");
        fileLogger.Error("This is an error message.");
        fileLogger.Warn("This is a warning message.");

        Console.WriteLine("\nMessages have been logged to the console and file.");
    }
}