using WarriorWars.Enum;
using WarriorWars.Equipment;

namespace WarriorWars
{
    class Warrior
    {
        private int goodGuyStartingHealth;
        private int badGuyStartingHealth;

        private Faction faction;

        private int health;
        private string name;
        private Weapon weapon;
        private Armor armor;

        #region Properties
        //auto property
        public bool IsAlive { get; }
        #endregion
    }
}
