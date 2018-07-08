using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Armor
    {
        #region Fields
        private const int GOOD_GUY_ARMOR = 5;
        private const int BAD_GUY_ARMOR = 5;

        private int armorPoints;
        #endregion

        #region Properties
        //block body
        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
        }
        #endregion

        #region Constructor
        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    armorPoints = GOOD_GUY_ARMOR;
                    break;
                case Faction.BadGuy:
                    armorPoints = BAD_GUY_ARMOR;
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}