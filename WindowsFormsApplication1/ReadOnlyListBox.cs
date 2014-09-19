using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InitiativeHelper
{
    public partial class ReadOnlyListBox : ListBox
    {
        private bool _readOnly = false;
        public bool ReadOnly
        {
            get { return _readOnly; }
            set { _readOnly = value; }
        }

        public ReadOnlyListBox()
        {
            InitializeComponent();
            this.DrawMode = DrawMode.OwnerDrawVariable; // We're using custom drawing.
        }

        protected override void DefWndProc(ref Message m)
        {
            // If ReadOnly is set to true, then block any messages 
            // to the selection area from the mouse or keyboard. 
            // Let all other messages pass through to the 
            // Windows default implementation of DefWndProc.
            if (!_readOnly || ((m.Msg <= 0x0200 || m.Msg >= 0x020E)
            && (m.Msg <= 0x0100 || m.Msg >= 0x0109)
            && m.Msg != 0x2111
            && m.Msg != 0x87))
            {
                base.DefWndProc(ref m);
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            // Make sure we're not trying to draw something that isn't there.
            if (e.Index >= this.Items.Count || e.Index <= -1)
                return;

            // Get the item object.
            object item = this.Items[e.Index];
            if (item == null)
                return;

            // Draw the background color depending on 
            // if the item is selected or not.
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                // The item is selected.
                // We want a blue background color.
                e.Graphics.FillRectangle(new SolidBrush(Color.LightBlue), e.Bounds);
            }
            else
            {
                // The item is NOT selected.
                // We want a white background color.
                e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);
            }

            // Draw the item.
            string text = item.ToString();
            SizeF stringSize = e.Graphics.MeasureString(text, this.Font);
            e.Graphics.DrawString(text, this.Font, new SolidBrush(Color.Black),
                new PointF(5, e.Bounds.Y + (e.Bounds.Height - stringSize.Height) / 2));
        }
    }

}
