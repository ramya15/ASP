using WarriorWars.Enum;
using WarriorWars.Equipment;

namespace WarriorWars
{
    class Warrior
    {
        #region Fields
        private int goodGuyStartingHealth;
        private int badGuyStartingHealth;

        private Faction faction;

        private int health;
        private string name;
        private Weapon weapon;
        private Armor armor;
        #endregion

        #region Properties
        //auto property
        public bool IsAlive { get; }
        #endregion

        #region Constructor
        //Shortcut: ctor
        public Warrior(string name, Faction faction)
        {
            //Initial values when a warrior is created
            this.name = name;
            this.faction = faction;
            IsAlive = true;

            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = goodGuyStartingHealth;
                    break;
                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = badGuyStartingHealth;
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
