using System;
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
        private bool isAlive;

        private Weapon weapon;
        private Armor armor;
        #endregion

        #region Properties
        //auto property
        //public bool IsAlive { get; }
        public bool IsAlive => isAlive;
        #endregion

        #region Constructor
        //Shortcut: ctor
        public Warrior(string name, Faction faction)
        {
            //Initial values when a warrior is created
            this.name = name;
            this.FACTION = faction;
            isAlive = true;

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

        #region Methods/Actions
        public void Attack(Warrior enemy)
        {
            //current player's weapon damage by enemy armor points.
            int damage = weapon.Damage / enemy.armor.ArmorPoints;
            enemy.health -= damage;

            if (enemy.health <= 0)
            {
                enemy.isAlive = false;
                Console.WriteLine($"{enemy.name} is dead and {name} is victorous!");
            }
                
        }

        #endregion
    }
}
