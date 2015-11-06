namespace InitiativeHelper
{
    partial class frmSetRound
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudRoundNumber = new System.Windows.Forms.NumericUpDown();
            this.btnSetRound = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoundNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // nudRoundNumber
            // 
            this.nudRoundNumber.Location = new System.Drawing.Point(12, 12);
            this.nudRoundNumber.Name = "nudRoundNumber";
            this.nudRoundNumber.Size = new System.Drawing.Size(82, 20);
            this.nudRoundNumber.TabIndex = 0;
            this.nudRoundNumber.ValueChanged += new System.EventHandler(this.nudRoundNumber_ValueChanged);
            // 
            // btnSetRound
            // 
            this.btnSetRound.Location = new System.Drawing.Point(115, 9);
            this.btnSetRound.Name = "btnSetRound";
            this.btnSetRound.Size = new System.Drawing.Size(75, 23);
            this.btnSetRound.TabIndex = 1;
            this.btnSetRound.Text = "Set Round";
            this.btnSetRound.UseVisualStyleBackColor = true;
            this.btnSetRound.Click += new System.EventHandler(this.btnSetRound_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(196, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSetRound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 43);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSetRound);
            this.Controls.Add(this.nudRoundNumber);
            this.Name = "frmSetRound";
            this.Text = "Set Round Number";
            ((System.ComponentModel.ISupportInitialize)(this.nudRoundNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudRoundNumber;
        private System.Windows.Forms.Button btnSetRound;
        private System.Windows.Forms.Button btnCancel;
    }
}