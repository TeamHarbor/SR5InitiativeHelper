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
    public partial class frmSetRound : Form
    {
        private bool changed = false;
        private decimal _newRoundValue;
        public decimal newRoundValue
        {
            get
            {
                if (changed)
                {
                    return _newRoundValue;
                }
                else
                {
                    return oldRoundValue;
                }
            }
        }
        public decimal oldRoundValue;

        public frmSetRound(int currentRound)
        {
            InitializeComponent();
            nudRoundNumber.Value = currentRound;
            oldRoundValue = currentRound;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudRoundNumber_ValueChanged(object sender, EventArgs e)
        {
            _newRoundValue = nudRoundNumber.Value;
        }

        private void btnSetRound_Click(object sender, EventArgs e)
        {
            changed = true;
            this.Close();
        }
    }
}
