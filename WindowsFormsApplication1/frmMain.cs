﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace InitiativeHelper
{
    public partial class frmMain : Form
    {
        List<clsCharacter> CastList = new List<clsCharacter>();
        List<clsTurn> TurnOrder = new List<clsTurn>();
        bool AltSortMethod = false;
        bool ResetConfirm = false;
        string EachRoundAction = "nothing";
        int Round = 0;

        public frmMain()
        {
            InitializeComponent();
            lblStatus.Text = "Loading...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frmMain_FormClosing);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(frmMain_MouseClick);
            clstCast.DoubleClick += new System.EventHandler(frmMain_clstCast_DoubleClick);
            clstCast.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(frmMain_clstCast_ItemCheck);
            clstCast.MouseDown += new System.Windows.Forms.MouseEventHandler(frmMain_clstCast_MouseClick);
            clstInitiative.BackgroundImage = InitiativeHelper.Properties.Resources.SR5_Gun_Battle_WashedOut;
            MakeDebugCharacters();
            lblStatus.Text = "Ready!";
        }

        public void frmMain_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {

        }

        public void frmMain_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if(ResetConfirm)
            {
                ResetConfirm = false;
                lblStatus.Text = "Ready!";
            }            
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
            CastList.Add(new clsCharacter() { Name = "Brian", Player = "Bryan", InitBase =7, InitDice = 1 });
            CastList.Add(new clsCharacter() { Name = "Hammerhead", Player = "Tyson", InitBase = 8, InitDice = 1 });
            CastList.Add(new clsCharacter() { Name = "Aundair", Player = "Victor", InitBase = 8, InitDice = 1 });
            CastList.Add(new clsCharacter() { Name = "Gearbox", Player = "Eric", InitBase = 8, InitDice = 1 });
            CastList.Add(new clsCharacter() { Name = "Gearbox - Matrix", Player = "Eric", InitBase = 7, InitDice = 4 });
            CastList.Add(new clsCharacter() { Name = "Sage", Player = "James", InitBase = 7, InitDice = 1 });
            CastList.Add(new clsCharacter() { Name = "Shasta", Player = "Shaun", InitBase = 7, InitDice = 1 });
            CastList.Add(new clsCharacter() { Name = "Shasta - Hot-Sim", Player = "Shaun", InitBase = 10, InitDice = 4, Enabled = false });
            CastList.Add(new clsCharacter() { Name = "Shasta - Cold-Sim", Player = "Shaun", InitBase = 10, InitDice = 3, Enabled = false });
            CastList.Add(new clsCharacter() { Name = "Toni", Player = "RJ", InitBase = 10, InitDice = 1 });
            CastList.Add(new clsCharacter() { Name = "Toni - Astral", Player = "RJ", InitBase = 12, InitDice = 2, Enabled = false });
            CastList.Add(new clsCharacter() { Name = "Sayna", Player = "Alex", InitBase = 7, InitDice = 1 });
            CastList.Add(new clsCharacter() { Name = "Sayna - Astral", Player = "Alex", InitBase = 6, InitDice = 2, Enabled = false });
            UpdateCast();
        }

        private void SetRound(int round)
        {
            Round = round;
            lblRound.Text = Round.ToString("00");
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

                if (c.Enabled && c.GoesFirst)
                    TurnOrder.Add(new clsTurn(c, 0, 0));

                foreach(int t in c.Turns)
                {
                    TurnOrder.Add(new clsTurn(c, t, pass));
                    pass++;
                }
            }

            if(AltSortMethod)
                TurnOrder.Sort(TurnSortMethodB);
            else
                TurnOrder.Sort(TurnSortMethodA);

            clstInitiative.Items.Clear();

            foreach(clsTurn t in TurnOrder)
            {                
                clstInitiative.Items.Add(t);
            }
        }

        /// <summary>
        /// Sort turns by TURN VALUE alone
        /// </summary>
        /// <param name="TurnA"></param>
        /// <param name="TurnB"></param>
        /// <returns></returns>
        int TurnSortMethodB(clsTurn TurnA, clsTurn TurnB)
        {
            if (TurnA.Value < TurnB.Value)
                return 1;
            else if (TurnA.Value > TurnB.Value)
                return -1;
            else
                return 0;
        }

        /// <summary>
        /// Sort turns by PASS(Ascending) then by TURN VALUE(Descending)
        /// </summary>
        /// <param name="TurnA"></param>
        /// <param name="TurnB"></param>
        /// <returns></returns>
        int TurnSortMethodA(clsTurn TurnA, clsTurn TurnB)
        {
            //Sort by PASS first, Ascending
            if (TurnA.Pass < TurnB.Pass)
                return -1;
            else if (TurnA.Pass > TurnB.Pass)
                return 1;
            else
            {
                //If both turns are on the same PASS, then sort by VALUE, descending
                if (TurnA.Value < TurnB.Value)
                    return 1;
                else if (TurnA.Value > TurnB.Value)
                    return -1;
                else
                    return 0;
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
                //Only increment the round if actually moving from the last index back to the first
                else if(clstInitiative.SelectedIndex != -1)
                {
                    SetRound(Round + 1);
                    NewRound();
                    clstInitiative.SetSelected(0, true);
                }
                else
                    clstInitiative.SetSelected(0, true);
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

            lblStatus.Text = ((clsTurn)clstInitiative.SelectedItem).Character.DisplayName + " is up! [Pass " + ((clsTurn)clstInitiative.SelectedItem).Pass + "]";
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
            if(!ResetConfirm)
            {
                lblStatus.Text = "Press the Reset button again to confirm";
                ResetConfirm = true;
            }
            else
            {
                SetRound(0);
                lblStatus.Text = "Ready!";
                ResetConfirm = false;
            }
        }

        private void chbIgnorePass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbIgnorePass.Checked)
                AltSortMethod = true;
            else
                AltSortMethod = false;

            UpdateInitiative();
        }
    }
}
