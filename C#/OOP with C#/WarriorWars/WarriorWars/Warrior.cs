using WarriorWars.Enum;
using WarriorWars.Equipment;

namespace WarriorWars
{
    class Warrior
    {
        #region Fields
        //set as constants to not alter the starting health
        private const int GOOD_GUY_STARTING_HEALTH = 100;
        private const int BAD_GUY_STARTING_HEALTH = 100;

        //readonly: 
        /* constant defined at runtime
         * can be assigned only in a constructor or variable initializer */
        private readonly Faction FACTION;

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
            this.FACTION = faction;
            IsAlive = true;

            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = GOOD_GUY_STARTING_HEALTH;
                    break;
                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = BAD_GUY_STARTING_HEALTH;
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
