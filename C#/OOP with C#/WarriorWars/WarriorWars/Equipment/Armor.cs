using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Armor
    {
        private int goodGuyArmor;
        private int badGuyArmor;

        private int armorPoints;

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
                    armorPoints = goodGuyArmor;
                    break;
                case Faction.BadGuy:
                    armorPoints = badGuyArmor;
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}