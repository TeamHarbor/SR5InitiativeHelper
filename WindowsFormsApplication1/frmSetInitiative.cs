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
    public partial class frmSetInitiative : Form
    {
        public clsCharacter Character;
        private bool unsafeClose = true;

        public frmSetInitiative()
        {
            InitializeComponent();
        }

        private void frmSetInitiative_Shown(object sender, EventArgs e)
        {
            lblMessage.Text = "Please enter an initiative for " + Character.DisplayName;
            this.Text = "Set Initiative for " + Character.DisplayName;
            lblEquation.Text = Character.InitBase + " + " + Character.InitDice + "d6 + " + Character.InitBonus;
            nudInitiative.Focus();
            nudInitiative.Select(0, 5);
            unsafeClose = true;
        }

        private void frmSetInitiative_Closing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if(unsafeClose)
                e.Cancel = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Character.CurrentInitiative = System.Convert.ToInt16(nudInitiative.Value);
            unsafeClose = false;
            this.Close();
        }
    }
}
