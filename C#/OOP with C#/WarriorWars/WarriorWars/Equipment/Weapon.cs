using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Weapon
    {
        #region Fields
        private const int GOOD_GUY_DAMAGE = 5;
        private const int BAD_GUY_DAMAGE = 5;

        private int damage;
        #endregion

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
                    damage = GOOD_GUY_DAMAGE;
                    break;
                case Faction.BadGuy:
                    damage = BAD_GUY_DAMAGE;
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
