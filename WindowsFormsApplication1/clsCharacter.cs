using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitiativeHelper
{
    class Character
    {
        public Guid ID;
        public int Index;
        public string Name = "New Character";
        public string Player = "GM";
        public int InitBase = 0;
        public int InitDice = 0;
        public int InitBonus = 0;
        public bool GoesFirst = false;
        public int CurrentInitiative = 0;
    }
}
