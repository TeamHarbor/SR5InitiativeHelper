namespace InitiativeHelper
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.clstInitiative = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clstCast = new System.Windows.Forms.CheckedListBox();
            this.btnRealDice = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRound = new System.Windows.Forms.ToolStripStatusLabel();
            this.pgbRound = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClearRounds = new System.Windows.Forms.Button();
            this.btnSetRound = new System.Windows.Forms.Button();
            this.ctmInitiative = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisableCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spendPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCast = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1.SuspendLayout();
            this.ctmInitiative.SuspendLayout();
            this.SuspendLayout();
            // 
            // clstInitiative
            // 
            this.clstInitiative.FormattingEnabled = true;
            this.clstInitiative.Location = new System.Drawing.Point(299, 28);
            this.clstInitiative.Name = "clstInitiative";
            this.clstInitiative.Size = new System.Drawing.Size(191, 199);
            this.clstInitiative.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(121, 230);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(202, 28);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(91, 94);
            this.btnRoll.TabIndex = 4;
            this.btnRoll.Text = "ROLL!";
            this.btnRoll.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(299, 230);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(415, 230);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cast";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Initiative";
            // 
            // clstCast
            // 
            this.clstCast.FormattingEnabled = true;
            this.clstCast.Location = new System.Drawing.Point(15, 28);
            this.clstCast.Name = "clstCast";
            this.clstCast.Size = new System.Drawing.Size(181, 199);
            this.clstCast.TabIndex = 7;
            // 
            // btnRealDice
            // 
            this.btnRealDice.Location = new System.Drawing.Point(202, 128);
            this.btnRealDice.Name = "btnRealDice";
            this.btnRealDice.Size = new System.Drawing.Size(91, 94);
            this.btnRealDice.TabIndex = 4;
            this.btnRealDice.Text = "Enter Manually";
            this.btnRealDice.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblRound,
            this.pgbRound,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 270);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(505, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel1.Text = "Round: ";
            // 
            // lblRound
            // 
            this.lblRound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(21, 17);
            this.lblRound.Text = "00";
            // 
            // pgbRound
            // 
            this.pgbRound.Maximum = 1000;
            this.pgbRound.Name = "pgbRound";
            this.pgbRound.Size = new System.Drawing.Size(100, 16);
            this.pgbRound.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(85, 17);
            this.toolStripStatusLabel2.Text = "                          ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // btnClearRounds
            // 
            this.btnClearRounds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearRounds.Location = new System.Drawing.Point(210, 272);
            this.btnClearRounds.Name = "btnClearRounds";
            this.btnClearRounds.Size = new System.Drawing.Size(46, 19);
            this.btnClearRounds.TabIndex = 9;
            this.btnClearRounds.Text = "Reset";
            this.btnClearRounds.UseVisualStyleBackColor = true;
            // 
            // btnSetRound
            // 
            this.btnSetRound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetRound.Location = new System.Drawing.Point(174, 272);
            this.btnSetRound.Name = "btnSetRound";
            this.btnSetRound.Size = new System.Drawing.Size(34, 19);
            this.btnSetRound.TabIndex = 9;
            this.btnSetRound.Text = "Set";
            this.btnSetRound.UseVisualStyleBackColor = true;
            // 
            // ctmInitiative
            // 
            this.ctmInitiative.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCharacterToolStripMenuItem,
            this.DisableCharacterToolStripMenuItem,
            this.spendPointsToolStripMenuItem});
            this.ctmInitiative.Name = "ctmInitiative";
            this.ctmInitiative.Size = new System.Drawing.Size(167, 70);
            this.ctmInitiative.Opening += new System.ComponentModel.CancelEventHandler(this.ctmInitiative_Opening);
            // 
            // editCharacterToolStripMenuItem
            // 
            this.editCharacterToolStripMenuItem.Name = "editCharacterToolStripMenuItem";
            this.editCharacterToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.editCharacterToolStripMenuItem.Text = "Edit Character";
            this.editCharacterToolStripMenuItem.Click += new System.EventHandler(this.editCharacterToolStripMenuItem_Click);
            // 
            // DisableCharacterToolStripMenuItem
            // 
            this.DisableCharacterToolStripMenuItem.Name = "DisableCharacterToolStripMenuItem";
            this.DisableCharacterToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.DisableCharacterToolStripMenuItem.Text = "Disable Character";
            // 
            // spendPointsToolStripMenuItem
            // 
            this.spendPointsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.spendPointsToolStripMenuItem.Name = "spendPointsToolStripMenuItem";
            this.spendPointsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.spendPointsToolStripMenuItem.Text = "Spend Points";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem2.Text = "5";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem3.Text = "10";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem4.Text = "15";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem5.Text = "20";
            // 
            // cmsCast
            // 
            this.cmsCast.Name = "cmsCast";
            this.cmsCast.Size = new System.Drawing.Size(61, 4);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 292);
            this.Controls.Add(this.btnSetRound);
            this.Controls.Add(this.btnClearRounds);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.clstCast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnRealDice);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.clstInitiative);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SR5 Initiative Helper";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ctmInitiative.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clstInitiative;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clstCast;
        private System.Windows.Forms.Button btnRealDice;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblRound;
        private System.Windows.Forms.ToolStripProgressBar pgbRound;
        private System.Windows.Forms.Button btnClearRounds;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button btnSetRound;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ContextMenuStrip ctmInitiative;
        private System.Windows.Forms.ToolStripMenuItem editCharacterToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsCast;
        private System.Windows.Forms.ToolStripMenuItem DisableCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spendPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
    }
}

