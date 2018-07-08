using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Weapon
    {
        private int goodGuyDamage;
        private int badGuyDamage;

        private int damage;

        #region Properties
        //expression body
        public int Damage => damage;
        #endregion

        #region Constructor
        public Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    damage = goodGuyDamage;
                    break;
                case Faction.BadGuy:
                    damage = badGuyDamage;
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
