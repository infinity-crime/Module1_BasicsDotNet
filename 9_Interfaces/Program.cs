using _9_Interfaces.Classes;

namespace _9_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var consoleLogger = new ConsoleLogger();
            var fileLogger = new FileLogger();

            consoleLogger.Log("test log 1");
            fileLogger.Log("test log 2");
        }
    }
}
