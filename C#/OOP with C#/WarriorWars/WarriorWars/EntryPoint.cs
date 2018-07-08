using System;
using WarriorWars.Enum;

namespace WarriorWars
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Warrior goodGuy = new Warrior("Eric", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Jones", Faction.BadGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (random.Next(1, 10) < 5)
                    goodGuy.Attack(badGuy);
                else
                    badGuy.Attack(goodGuy);
            }
        }
    }
}
