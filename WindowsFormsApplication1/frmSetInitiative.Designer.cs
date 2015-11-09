namespace InitiativeHelper
{
    partial class frmSetInitiative
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
            this.nudInitiative = new System.Windows.Forms.NumericUpDown();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblEquation = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitiative)).BeginInit();
            this.SuspendLayout();
            // 
            // nudInitiative
            // 
            this.nudInitiative.Location = new System.Drawing.Point(176, 46);
            this.nudInitiative.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInitiative.Name = "nudInitiative";
            this.nudInitiative.Size = new System.Drawing.Size(76, 20);
            this.nudInitiative.TabIndex = 0;
            this.nudInitiative.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(9, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(137, 13);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Please enter an initiative for";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(258, 43);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblEquation
            // 
            this.lblEquation.Location = new System.Drawing.Point(12, 43);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.Size = new System.Drawing.Size(139, 23);
            this.lblEquation.TabIndex = 3;
            this.lblEquation.Text = "label1";
            this.lblEquation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "=";
            // 
            // frmSetInitiative
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 105);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEquation);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.nudInitiative);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetInitiative";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Initiative";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSetInitiative_Closing);
            this.Shown += new System.EventHandler(this.frmSetInitiative_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nudInitiative)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudInitiative;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblEquation;
        private System.Windows.Forms.Label label5;
    }
}