using System;
using System.Threading;
using WarriorWars.Enum;

namespace WarriorWars
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Warrior goodGuy = new Warrior("Eric", Faction.GoodGuy);
            Warrior badGuy = new Warrior("John", Faction.BadGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (random.Next(1, 10) < 5)
                    goodGuy.Attack(badGuy);
                else
                    badGuy.Attack(goodGuy);

                Thread.Sleep(50);
            }

            Tools.ColorfulWriteLine(Construct.text, ConsoleColor.DarkCyan);
        }

        //Static class with Static Constructor
        static class Construct
        {
            public static string text = ":=)";
            static Construct()
            {
                Console.Write("Play Again ");
            }
        }
    }
}
