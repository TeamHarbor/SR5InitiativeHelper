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
        private bool Unsaved;

        public frmCharacter()
        {
            InitializeComponent();
            this.txtCharacterName.TextChanged += new System.EventHandler(this.frmCharacter_ControlChanged);
            this.txtPlayerName.TextChanged += new System.EventHandler(this.frmCharacter_ControlChanged);
            this.nudInitBase.ValueChanged += new System.EventHandler(this.frmCharacter_ControlChanged);
            this.nudInitDice.ValueChanged += new System.EventHandler(this.frmCharacter_ControlChanged);
            this.nudInitBonus.ValueChanged += new System.EventHandler(this.frmCharacter_ControlChanged);
            this.chkGoesFirst.CheckedChanged += new System.EventHandler(this.frmCharacter_ControlChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCharacter_Closing);
        }

        private void frmCharacter_Shown(object sender, EventArgs e)
        {
            lblCharacterID.Text = System.Convert.ToString(Character.ID);
            txtCharacterName.Text = Character.Name;
            txtPlayerName.Text = Character.Player;
            nudInitBase.Value = Character.InitBase;
            nudInitDice.Value = Character.InitDice;
            nudInitBonus.Value = Character.InitBonus;
            chkGoesFirst.Checked = Character.GoesFirst;
            Unsaved = false;
        }

        private void frmCharacter_ControlChanged(object sender, EventArgs e)
        {
            Unsaved = true;
        }

        public void ApplyChanges()
        {
            Character.Name = txtCharacterName.Text;
            Character.Player = txtPlayerName.Text;
            Character.InitBase = System.Convert.ToInt16(nudInitBase.Value);
            Character.InitDice = System.Convert.ToInt16(nudInitDice.Value);
            Character.InitBonus = System.Convert.ToInt16(nudInitBonus.Value);
            Character.GoesFirst = chkGoesFirst.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ApplyChanges();
            Unsaved = false;
            this.Close();
        }

        bool ConfirmClose()
        {
            bool result;

            if (Unsaved)
            {
                DialogResult confirm = MessageBox.Show("You have made some unsaved changes, would you like to save these changes before exiting?", "Wait!", MessageBoxButtons.YesNoCancel);

                switch (confirm)
                {
                    case DialogResult.Yes:
                        ApplyChanges();
                        result = true;
                        break;
                    case DialogResult.No:
                        result = true;
                        break;
                    case DialogResult.Cancel:
                        result = false;
                        break;
                    default:
                        result = false;
                        break;
                }
            }
            else
                result = true;

            return result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCharacter_Closing(object sender, FormClosingEventArgs e)
        {
            if (!ConfirmClose())
            {
                e.Cancel = true;
            }
        }
    }
}
