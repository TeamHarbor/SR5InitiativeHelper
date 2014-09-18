using System;

namespace InitiativeHelper
{
    public class clsTurn : System.IComparable<clsTurn>
    {
        int IComparable<clsTurn>.CompareTo(clsTurn Turn)
        {
            return this.ToString().CompareTo(Turn.ToString());
        }

        private string DisplayName
        {
            get
            {
                return "[" + _value.ToString("00") + "] " + _character.DisplayName;
            }
        }
        private clsCharacter _character;
        public clsCharacter Character
        {
            get {return _character;}
            set {_character = value;}
        }

        private int _value;
        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        private int _pass;
        public int Pass
        {
            get { return _pass; }
            set { _pass = value; }
        }

        public clsTurn(clsCharacter Character, int Value, int Pass)
        {
            _character = Character;
            _value = Value;
            _pass = Pass;
        }

        public override string ToString()
        {
            return DisplayName;
        }
    }
}
