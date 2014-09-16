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

        public frmMain()
        {
            InitializeComponent();
            clstCast.DoubleClick += new System.EventHandler(frmMain_clstCast_DoubleClick);
            clstCast.DisplayMember = "DisplayName";
            clstInitiative.DisplayMember = "DisplayInitiative";
        }

        private void frmMain_clstCast_DoubleClick(object sender, EventArgs e)
        {
            if (clstCast.SelectedIndex > -1)
                EditCharacter((clsCharacter)clstCast.SelectedItem);

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
            Random rnd = new Random();
            int Initdice;
            int DiceResult;

            foreach(clsCharacter c in CastList)
            {
                Initdice = c.InitDice;

                DiceResult = rnd.Next(Initdice, Initdice * 6);

                c.CurrentInitiative = c.InitBase + c.InitBonus + DiceResult;
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

            foreach (clsCharacter c in CastList)
            {
                clstCast.Items.Add(c);
            }
        }

        public void UpdateInitiative()
        {
            clstInitiative.Items.Clear();

            foreach (clsCharacter c in CastList)
            {
                if (c.Enabled)
                    for (int x = c.CurrentInitiative; x > 0; x -= 10)
                    {
                        clstInitiative.Items.Add(c);
                    }
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

        }

    }
}
