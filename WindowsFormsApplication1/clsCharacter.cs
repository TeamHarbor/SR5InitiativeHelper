namespace InitiativeHelper
{
    public class clsCharacter
    {
        public readonly System.Guid ID;
        public bool Enabled;
        public string Name;
        public string Player;
        public int InitBase;
        public int InitDice;
        public int InitBonus;
        public bool GoesFirst;
        public int CurrentInitiative;

        public clsCharacter()
        {
            ID = System.Guid.NewGuid();
            Name = "New Character";
            Player = "GM";
            InitBase = 0;
            InitDice = 0;
            InitBonus = 0;
            GoesFirst = false;
            CurrentInitiative = 0;
            Enabled = true;
        }

        public void Roll()
        {

        }

        /// <summary>
        /// Set the selected attribute to the desired value.
        /// </summary>
        /// <param name="attribute">Attribute to be set; name, player, init.base, init.dice, init.bonus, init.current, or first</param>
        /// <param name="value">Desired value of selected attribute in string format</param>
        public void Set(string attribute, string value)
        {
            switch(attribute)
            {
                case "name":
                    Name = value;
                    break;
                case "player":
                    Player = value;
                    break;
                case "init.base":
                    InitBase = System.Convert.ToInt16(value);
                    break;
                case "init.dice":
                    InitDice = System.Convert.ToInt16(value);
                    break;
                case "init.bonus":
                    InitBonus = System.Convert.ToInt16(value);
                    break;
                case "init.current":
                    CurrentInitiative = System.Convert.ToInt16(value);
                    break;
                case "first":
                    GoesFirst = System.Convert.ToBoolean(value);
                    break;
                default:
                    break;
            }

        }
    }
}
