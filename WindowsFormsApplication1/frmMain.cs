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
    public partial class frmMain : Form
    {
        List<clsCharacter> CastList = new List<clsCharacter>();
        List<clsTurn> TurnOrder = new List<clsTurn>();

        public frmMain()
        {
            InitializeComponent();
            clstCast.DoubleClick += new System.EventHandler(frmMain_clstCast_DoubleClick);
            MakeDebugCharacters();
            clstCast.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(frmMain_clstCast_ItemCheck);
        }

        private void frmMain_clstCast_DoubleClick(object sender, EventArgs e)
        {
            if (clstCast.SelectedIndex > -1)
                EditCharacter((clsCharacter)clstCast.SelectedItem);

        }

        private void frmMain_clstCast_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            clsCharacter character = clstCast.Items[e.Index] as clsCharacter;
            if (e.NewValue == System.Windows.Forms.CheckState.Checked)
                character.Enabled = true;
            else
                character.Enabled = false;
        }

        private void MakeDebugCharacters()
        {
            CastList.Add(new clsCharacter() { Name = "Baddie1", Player = "GM", InitBase = 10, InitDice = 4 });
            CastList.Add(new clsCharacter() { Name = "Baddie2", Player = "GM", InitBase = 15, InitDice = 1, Enabled = false});
            CastList.Add(new clsCharacter() { Name = "Doc", Player = "Troy", InitBase = 8, InitDice = 2 });
            CastList.Add(new clsCharacter() { Name = "Green Leaf", Player = "Isaac", InitBase = 13, InitDice = 3 });
            CastList.Add(new clsCharacter() { Name = "Cable", Player = "GM", InitBase = 11, InitDice = 3 });

            UpdateCast();
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

        private void RollInitiative()
        {
            foreach(clsCharacter c in CastList)
            {
                if(c.Enabled)
                    c.Roll();
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

        private void ctmInitiative_Opening(object sender, CancelEventArgs e)
        {

        }

        private void editCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void btnRoll_Click(object sender, EventArgs e)
        {
            RollInitiative();
        }

    }
}
