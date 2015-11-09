using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml;

namespace InitiativeHelper
{
    public partial class frmMain : Form
    {
        XmlDocument CastFile = new XmlDocument();
        List<clsCharacter> CastList = new List<clsCharacter>();
        List<clsTurn> TurnOrder = new List<clsTurn>();
        bool AltSortMethod = false;
        bool ResetConfirm = false;
        string EachRoundAction = "nothing";
        int Round = 0;

        public frmMain()
        {
            InitializeComponent();
            lblStatus.Text = "Loading Cast";

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frmMain_FormClosing);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(frmMain_MouseClick);
            clstCast.DoubleClick += new System.EventHandler(frmMain_clstCast_DoubleClick);
            clstCast.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(frmMain_clstCast_ItemCheck);
            clstCast.MouseDown += new System.Windows.Forms.MouseEventHandler(frmMain_clstCast_MouseClick);
            clstInitiative.BackgroundImage = InitiativeHelper.Properties.Resources.SR5_Gun_Battle_WashedOut;
            lblStatus.Text = "Ready!";
        }

        public void frmMain_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (!ConfirmClose())
            {
                e.Cancel = true;
            }
        }

        bool ConfirmClose()
        {
            bool result;

            if (true) // Will confirm unsaved state in future release
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to exit?", "Wait!", MessageBoxButtons.YesNo);

                switch (confirm)
                {
                    case DialogResult.Yes:
                        //ApplyChanges(); //Unused in this form
                        result = true;
                        break;
                    case DialogResult.No:
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
            CastList.Add(new clsCharacter() { Name = "Brian", Player = "Bryan", InitBase = 7, InitDice = 1 });
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

        private void cmsCast_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void DisableCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //Spend 5 Points
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            clsTurn selected = (clsTurn)clstInitiative.SelectedItem;

            if (selected != null)
            {
                selected.Character.Spend(5);
                UpdateInitiative();
            }
        }

        private void btnSetRound_Click(object sender, EventArgs e)
        {
            frmSetRound Dialog = new frmSetRound(Round);
            Dialog.ShowDialog();
            SetRound(System.Convert.ToInt16(Dialog.newRoundValue));
            Dialog.Dispose();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fn;
            saveFileDialog1.InitialDirectory = Properties.Settings.Default.last_save;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.Xml.Serialization.XmlSerializer serializer;
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.DefaultExt = ".cast";
                saveFileDialog1.Title = "Save Cast List";
                fn = saveFileDialog1.FileName;
                if (!System.IO.File.Exists(fn))
                {
                    MessageBox.Show("Cast list saving has not yet been configured. This will be added in a future release.");
                }
                else
                {
                    MessageBox.Show("Cast list saving has not yet been configured. This will be added in a future release.");
                }
            }
        }

        private void generateDebugCastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeDebugCharacters();
        }
    }
}
