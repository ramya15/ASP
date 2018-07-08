using System;

namespace IntroToOOP
{
    //Static Class =: equivalent of Singleton Design Pattern
    //Static class cannot have a constructor as they cannot be instantited (as they do not need one)
    public static class Utilities
    {
        public static void ColorWriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
