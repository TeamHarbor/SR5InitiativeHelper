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
            this.cmsInitiative = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisableCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spendPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clstCast = new System.Windows.Forms.CheckedListBox();
            this.cmsCast = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reRollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRealDice = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRound = new System.Windows.Forms.ToolStripStatusLabel();
            this.pgbRound = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClearRounds = new System.Windows.Forms.Button();
            this.btnSetRound = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rdbRoll = new System.Windows.Forms.RadioButton();
            this.rdbNothing = new System.Windows.Forms.RadioButton();
            this.rdbManual = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.chbIgnorePass = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.clstInitiative = new InitiativeHelper.ReadOnlyListBox();
            this.generateDebugCastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsInitiative.SuspendLayout();
            this.cmsCast.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsInitiative
            // 
            this.cmsInitiative.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCharacterToolStripMenuItem,
            this.DisableCharacterToolStripMenuItem,
            this.spendPointsToolStripMenuItem});
            this.cmsInitiative.Name = "ctmInitiative";
            this.cmsInitiative.Size = new System.Drawing.Size(156, 70);
            // 
            // editCharacterToolStripMenuItem
            // 
            this.editCharacterToolStripMenuItem.Name = "editCharacterToolStripMenuItem";
            this.editCharacterToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.editCharacterToolStripMenuItem.Text = "Edit";
            this.editCharacterToolStripMenuItem.Click += new System.EventHandler(this.editCharacterToolStripMenuItem_Click);
            // 
            // DisableCharacterToolStripMenuItem
            // 
            this.DisableCharacterToolStripMenuItem.Name = "DisableCharacterToolStripMenuItem";
            this.DisableCharacterToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.DisableCharacterToolStripMenuItem.Text = "Toggle Enabled";
            this.DisableCharacterToolStripMenuItem.Click += new System.EventHandler(this.DisableCharacterToolStripMenuItem_Click);
            // 
            // spendPointsToolStripMenuItem
            // 
            this.spendPointsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.spendPointsToolStripMenuItem.Name = "spendPointsToolStripMenuItem";
            this.spendPointsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.spendPointsToolStripMenuItem.Text = "Spend Points";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem2.Text = "5";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(121, 253);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(202, 51);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(91, 54);
            this.btnRoll.TabIndex = 4;
            this.btnRoll.Text = "ROLL!";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(299, 253);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(415, 253);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cast";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Initiative";
            // 
            // clstCast
            // 
            this.clstCast.CheckOnClick = true;
            this.clstCast.FormattingEnabled = true;
            this.clstCast.Location = new System.Drawing.Point(0, 19);
            this.clstCast.Name = "clstCast";
            this.clstCast.Size = new System.Drawing.Size(181, 199);
            this.clstCast.TabIndex = 7;
            // 
            // cmsCast
            // 
            this.cmsCast.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.removeToolStripMenuItem1,
            this.reRollToolStripMenuItem,
            this.setToolStripMenuItem,
            this.disableToolStripMenuItem});
            this.cmsCast.Name = "cmsCast";
            this.cmsCast.Size = new System.Drawing.Size(156, 136);
            this.cmsCast.Opening += new System.ComponentModel.CancelEventHandler(this.cmsCast_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.editToolStripMenuItem.Text = "Add";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.removeToolStripMenuItem.Text = "Edit";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.removeToolStripMenuItem1.Text = "Remove";
            this.removeToolStripMenuItem1.Click += new System.EventHandler(this.removeToolStripMenuItem1_Click);
            // 
            // reRollToolStripMenuItem
            // 
            this.reRollToolStripMenuItem.Name = "reRollToolStripMenuItem";
            this.reRollToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.reRollToolStripMenuItem.Text = "Re-Roll";
            this.reRollToolStripMenuItem.Click += new System.EventHandler(this.reRollToolStripMenuItem_Click);
            // 
            // setToolStripMenuItem
            // 
            this.setToolStripMenuItem.Name = "setToolStripMenuItem";
            this.setToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.setToolStripMenuItem.Text = "Set";
            this.setToolStripMenuItem.Click += new System.EventHandler(this.setToolStripMenuItem_Click);
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.disableToolStripMenuItem.Text = "Toggle Enabled";
            // 
            // btnRealDice
            // 
            this.btnRealDice.Location = new System.Drawing.Point(202, 111);
            this.btnRealDice.Name = "btnRealDice";
            this.btnRealDice.Size = new System.Drawing.Size(91, 56);
            this.btnRealDice.TabIndex = 4;
            this.btnRealDice.Text = "Enter Manually";
            this.btnRealDice.UseVisualStyleBackColor = true;
            this.btnRealDice.Click += new System.EventHandler(this.btnRealDice_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblRound,
            this.pgbRound,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(511, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(0, 3, -7, 2);
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
            this.pgbRound.Name = "pgbRound";
            this.pgbRound.Size = new System.Drawing.Size(100, 16);
            this.pgbRound.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(82, 17);
            this.toolStripStatusLabel2.Text = "                         ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(75, 17);
            this.lblStatus.Text = "[StatusLabel]";
            // 
            // btnClearRounds
            // 
            this.btnClearRounds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearRounds.Location = new System.Drawing.Point(203, 421);
            this.btnClearRounds.Name = "btnClearRounds";
            this.btnClearRounds.Size = new System.Drawing.Size(46, 19);
            this.btnClearRounds.TabIndex = 9;
            this.btnClearRounds.Text = "Reset";
            this.btnClearRounds.UseVisualStyleBackColor = true;
            this.btnClearRounds.Click += new System.EventHandler(this.btnClearRounds_Click);
            // 
            // btnSetRound
            // 
            this.btnSetRound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetRound.Location = new System.Drawing.Point(167, 421);
            this.btnSetRound.Name = "btnSetRound";
            this.btnSetRound.Size = new System.Drawing.Size(34, 19);
            this.btnSetRound.TabIndex = 9;
            this.btnSetRound.Text = "Set";
            this.btnSetRound.UseVisualStyleBackColor = true;
            this.btnSetRound.Click += new System.EventHandler(this.btnSetRound_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(511, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.generateDebugCastToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // rdbRoll
            // 
            this.rdbRoll.AutoSize = true;
            this.rdbRoll.Location = new System.Drawing.Point(204, 190);
            this.rdbRoll.Name = "rdbRoll";
            this.rdbRoll.Size = new System.Drawing.Size(43, 17);
            this.rdbRoll.TabIndex = 11;
            this.rdbRoll.Text = "Roll";
            this.rdbRoll.UseVisualStyleBackColor = true;
            this.rdbRoll.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbNothing
            // 
            this.rdbNothing.AutoSize = true;
            this.rdbNothing.Checked = true;
            this.rdbNothing.Location = new System.Drawing.Point(204, 236);
            this.rdbNothing.Name = "rdbNothing";
            this.rdbNothing.Size = new System.Drawing.Size(79, 17);
            this.rdbNothing.TabIndex = 11;
            this.rdbNothing.TabStop = true;
            this.rdbNothing.Text = "Do Nothing";
            this.rdbNothing.UseVisualStyleBackColor = true;
            this.rdbNothing.CheckedChanged += new System.EventHandler(this.rdbNothing_CheckedChanged);
            // 
            // rdbManual
            // 
            this.rdbManual.AutoSize = true;
            this.rdbManual.Location = new System.Drawing.Point(204, 213);
            this.rdbManual.Name = "rdbManual";
            this.rdbManual.Size = new System.Drawing.Size(95, 17);
            this.rdbManual.TabIndex = 11;
            this.rdbManual.Text = "Enter Manually";
            this.rdbManual.UseVisualStyleBackColor = true;
            this.rdbManual.CheckedChanged += new System.EventHandler(this.rdbManual_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Each Round:";
            // 
            // chbIgnorePass
            // 
            this.chbIgnorePass.AutoSize = true;
            this.chbIgnorePass.Location = new System.Drawing.Point(72, 2);
            this.chbIgnorePass.Name = "chbIgnorePass";
            this.chbIgnorePass.Size = new System.Drawing.Size(118, 17);
            this.chbIgnorePass.TabIndex = 13;
            this.chbIgnorePass.Text = "Cascading Initiative";
            this.chbIgnorePass.UseVisualStyleBackColor = true;
            this.chbIgnorePass.CheckedChanged += new System.EventHandler(this.chbIgnorePass_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(0, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(475, 104);
            this.textBox1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Notes";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(15, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 121);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.clstCast);
            this.panel2.Location = new System.Drawing.Point(15, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 218);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.chbIgnorePass);
            this.panel3.Controls.Add(this.clstInitiative);
            this.panel3.Location = new System.Drawing.Point(299, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 218);
            this.panel3.TabIndex = 18;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "cast";
            this.saveFileDialog1.FileName = "Default.cast";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // clstInitiative
            // 
            this.clstInitiative.ContextMenuStrip = this.cmsInitiative;
            this.clstInitiative.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.clstInitiative.FormattingEnabled = true;
            this.clstInitiative.Location = new System.Drawing.Point(0, 19);
            this.clstInitiative.Name = "clstInitiative";
            this.clstInitiative.ReadOnly = false;
            this.clstInitiative.Size = new System.Drawing.Size(191, 199);
            this.clstInitiative.TabIndex = 0;
            this.clstInitiative.SelectedIndexChanged += new System.EventHandler(this.clstInitiative_SelectedIndexChanged);
            // 
            // generateDebugCastToolStripMenuItem
            // 
            this.generateDebugCastToolStripMenuItem.Name = "generateDebugCastToolStripMenuItem";
            this.generateDebugCastToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.generateDebugCastToolStripMenuItem.Text = "Generate Debug Cast";
            this.generateDebugCastToolStripMenuItem.Click += new System.EventHandler(this.generateDebugCastToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InitiativeHelper.Properties.Resources.SR5_Gun_Battle_WashedOut;
            this.ClientSize = new System.Drawing.Size(511, 441);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbManual);
            this.Controls.Add(this.rdbNothing);
            this.Controls.Add(this.rdbRoll);
            this.Controls.Add(this.btnSetRound);
            this.Controls.Add(this.btnClearRounds);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnRealDice);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SR5 Initiative Helper";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.cmsInitiative.ResumeLayout(false);
            this.cmsCast.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InitiativeHelper.ReadOnlyListBox clstInitiative;
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
        private System.Windows.Forms.ContextMenuStrip cmsInitiative;
        private System.Windows.Forms.ToolStripMenuItem editCharacterToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsCast;
        private System.Windows.Forms.ToolStripMenuItem DisableCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spendPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reRollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.RadioButton rdbRoll;
        private System.Windows.Forms.RadioButton rdbNothing;
        private System.Windows.Forms.RadioButton rdbManual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.CheckBox chbIgnorePass;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem generateDebugCastToolStripMenuItem;
    }
}

