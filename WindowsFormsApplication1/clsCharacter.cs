using System;

namespace InitiativeHelper
{
    [Serializable]
    public class clsCharacter : IComparable<clsCharacter>, IEquatable<clsCharacter>
    {
        public readonly System.Guid ID;
        public bool Enabled;
        public string DisplayName
        {
            get
            { return Name + " (" + Player + ")"; }
        }
        public string Name;
        public string Player;
        public int InitBase;
        public int InitDice;
        public int InitBonus;
        public bool GoesFirst;
        public int CurrentInitiative;
        public System.Collections.Generic.List<int> Turns;
        public int DiceResult;

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
            Turns = new System.Collections.Generic.List<int>();
        }

        int IComparable<clsCharacter>.CompareTo(clsCharacter character)
        {
            return DisplayName.CompareTo(character.DisplayName);
        }

        bool IEquatable<clsCharacter>.Equals(clsCharacter character)
        {
            return ID.Equals(character.ID);
        }

        public override string ToString()
        {
            return DisplayName;
        }

        public void Roll()
        {
            System.Random rnd = new System.Random();

            DiceResult = 0;

            for (int x = 0; x < InitDice; x++)
            {
                DiceResult += rnd.Next(1,6);
            }

            CurrentInitiative = InitBase + InitBonus + DiceResult;
        }

        public void makeTurns()
        {
            Turns.Clear();

            int x = CurrentInitiative;
            if (Enabled)
                while (x > 0)
                {
                    Turns.Add(x);
                    x -= 10;
                }
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

        public void Spend(int Amount)
        {
            Set("init.current", System.Convert.ToString(CurrentInitiative - Amount));
        }
    }
}
