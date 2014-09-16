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
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCharacter create = new frmCharacter();
            clsCharacter character = new clsCharacter();
            CastList.Add(character);
            create.Character = character;
            create.ShowDialog();
            UpdateCast();
        }

        public void UpdateCast()
        {
            clstCast.Items.Clear();

            foreach (clsCharacter c in CastList)
            {
                clstCast.Items.Add(c.Name);
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

    }
}
