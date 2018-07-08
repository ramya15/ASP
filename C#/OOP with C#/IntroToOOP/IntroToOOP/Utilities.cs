using System;

namespace IntroToOOP
{
    //Static Class (Singleton Design Pattern)
    public static class Utilities
    {
        public static void ColorWriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
        }
    }
}
