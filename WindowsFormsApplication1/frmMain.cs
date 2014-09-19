using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace InitiativeHelper
{
    public partial class frmMain : Form
    {
        List<clsCharacter> CastList = new List<clsCharacter>();
        List<clsTurn> TurnOrder = new List<clsTurn>();
        string EachRoundAction = "nothing";
        int Round = 0;

        public frmMain()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frmMain_FormClosing);
            clstCast.DoubleClick += new System.EventHandler(frmMain_clstCast_DoubleClick);
            clstCast.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(frmMain_clstCast_ItemCheck);
            clstCast.MouseDown += new System.Windows.Forms.MouseEventHandler(frmMain_clstCast_MouseClick);
            MakeDebugCharacters();
        }

        public void frmMain_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {

        }

        private void frmMain_clstCast_DoubleClick(object sender, EventArgs e)
        {
            //if (clstCast.SelectedIndex > -1)
            //    EditCharacter((clsCharacter)clstCast.SelectedItem);
        }

        private void frmMain_clstCast_MouseClick(object sender, MouseEventArgs e)
        {
            clstCast.SelectedIndex = clstCast.IndexFromPoint(e.X, e.Y);

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                cmsCast.Show(clstCast, e.Location);
            }
        }

        private void frmMain_clstCast_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            clsCharacter character = clstCast.Items[e.Index] as clsCharacter;
            if (e.NewValue == System.Windows.Forms.CheckState.Checked)
                character.Enabled = true;
            else
                character.Enabled = false;

            UpdateInitiative();
        }

        private void MakeDebugCharacters()
        {
            CastList.Add(new clsCharacter() { Name = "Baddie1", Player = "GM", InitBase = 10, InitDice = 4 });
            CastList.Add(new clsCharacter() { Name = "Baddie2", Player = "GM", InitBase = 15, InitDice = 1, Enabled = false});
            CastList.Add(new clsCharacter() { Name = "Doc", Player = "Troy", InitBase = 8, InitDice = 2 });
            CastList.Add(new clsCharacter() { Name = "Green Leaf", Player = "Isaac", InitBase = 13, InitDice = 3, InitBonus = 8});
            CastList.Add(new clsCharacter() { Name = "Cable", Player = "James", InitBase = 11, InitDice = 3 });
            UpdateCast();
        }

        private void SetRound(int round)
        {
            Round = round;
            lblRound.Text = Round.ToString();
        }

        private void NewRound()
        {
            switch(EachRoundAction)
            {
                case "roll":
                    RollInitiative();
                    break;
                case "manual":
                    EnterInitiative();
                    break;
                case "nothing":
                    break;
                default:
                    break;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCharacter();
        }

        private void AddCharacter()
        {
            clsCharacter character = new clsCharacter();
            CastList.Add(character);
            EditCharacter(character);
        }

        private void RemoveCharacter(clsCharacter character)
        {
            CastList.Remove(character);
            UpdateCast();
        }

        private void RollInitiative()
        {
            foreach(clsCharacter c in CastList)
            {
                if(c.Enabled)
                    c.Roll();
            }

            UpdateInitiative();
        }

        private void EnterInitiative()
        {
            frmSetInitiative dialog = new frmSetInitiative();

            foreach (clsCharacter c in CastList)
            {
                dialog.Character = c;

                if (c.Enabled)
                    dialog.ShowDialog();
            }

            UpdateInitiative();
        }

        private void EditCharacter(clsCharacter character)
        {
            frmCharacter dialog = new frmCharacter();
            dialog.Character = character;
            dialog.ShowDialog();
            UpdateCast();
        }

        public void UpdateCast()
        {
            clstCast.Items.Clear();
            int i = 0;

            foreach (clsCharacter c in CastList)
            {
                clstCast.Items.Add(c);
                if (c.Enabled)
                    clstCast.SetItemChecked(i,true);
                else
                    clstCast.SetItemChecked(i, false);

                i++;
            }
        }

        public void UpdateInitiative()
        {
            TurnOrder.Clear();

            foreach (clsCharacter c in CastList)
            {
                c.makeTurns();
                int pass = 1;
                foreach(int t in c.Turns)
                {
                    TurnOrder.Add(new clsTurn(c, t, pass));
                    pass++;
                }
            }

            TurnOrder.Sort();
            TurnOrder.Reverse();

            clstInitiative.Items.Clear();

            foreach(clsTurn t in TurnOrder)
            {                
                clstInitiative.Items.Add(t);
            }
        }

        #region Context Menus

        private void editCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void btnRoll_Click(object sender, EventArgs e)
        {
            RollInitiative();
        }

        private void btnRealDice_Click(object sender, EventArgs e)
        {
            EnterInitiative();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCharacter();
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (clstCast.SelectedIndex > -1)
                RemoveCharacter((clsCharacter)clstCast.SelectedItem);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (clstCast.SelectedIndex > -1)
                RemoveCharacter((clsCharacter)clstCast.SelectedItem);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(clstCast.SelectedIndex > -1)
                EditCharacter((clsCharacter)clstCast.SelectedItem);
        }

        private void reRollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(clstCast.SelectedIndex > -1)
            {
                clsCharacter character = (clsCharacter)clstCast.SelectedItem;
                character.Roll();
                UpdateInitiative();
            }                
        }

        private void setToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clstCast.SelectedIndex > -1)
            {
                clsCharacter character = (clsCharacter)clstCast.SelectedItem;
                frmSetInitiative dialog = new frmSetInitiative();
                dialog.Character = character;
                dialog.ShowDialog();
                UpdateInitiative();
            }   
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();

            about.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (clstInitiative.Items.Count > 0)
            {
                if (clstInitiative.SelectedIndex > -1 && clstInitiative.SelectedIndex < clstInitiative.Items.Count - 1)
                    clstInitiative.SetSelected(clstInitiative.SelectedIndex + 1, true);
                else
                {
                    SetRound(Round + 1);
                    NewRound();
                    clstInitiative.SetSelected(0, true);
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (clstInitiative.Items.Count > 0)
            {
                if (clstInitiative.SelectedIndex > 0)
                    clstInitiative.SetSelected(clstInitiative.SelectedIndex - 1, true);
                else
                {
                    SetRound(Round - 1);
                    clstInitiative.SetSelected(clstInitiative.Items.Count - 1, true);
                }
            }
        }

        private void clstInitiative_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal progress;

            progress = ((System.Convert.ToDecimal(clstInitiative.SelectedIndex) + 1) / System.Convert.ToDecimal(clstInitiative.Items.Count)) * 100;

            Math.Round(progress);

            pgbRound.Value = System.Convert.ToInt16(progress);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRoll.Checked)
                EachRoundAction = "roll";
        }

        private void rdbManual_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbManual.Checked)
                EachRoundAction = "manual";
        }

        private void rdbNothing_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNothing.Checked)
                EachRoundAction = "nothing";
        }

        private void btnClearRounds_Click(object sender, EventArgs e)
        {
            SetRound(0);
        }
    }
}
