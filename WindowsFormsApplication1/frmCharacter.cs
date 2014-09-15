using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InitiativeHelper
{
    public partial class frmCharacter : Form
    {
        public clsCharacter Character;

        public frmCharacter()
        {
            InitializeComponent();
        }

        private void frmCharacter_Load(object sender, EventArgs e)
        {
            lblCharacterID.Text = System.Convert.ToString(Character.ID);
            txtCharacterName.Text = Character.Name;
            txtPlayerName.Text = Character.Player;
            nudInitBase.Value = Character.InitBase;
            nudInitDice.Value = Character.InitDice;
            nudInitBonus.Value = Character.InitBonus;
            chkGoesFirst.Checked = Character.GoesFirst;
        }
    }
}
