namespace TheBetterLimited_Server.Helpers.LogHelper
{
    public class ConsoleLogger
    {
        public static void Debug(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        public static void Debug(object msg)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(msg.ToString());
            Console.ResetColor();
        }
    }
}