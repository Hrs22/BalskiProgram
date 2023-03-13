namespace ChristmasProgram
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.txtBoxWelcome = new System.Windows.Forms.RichTextBox();
            this.txtBoxYourBalance = new System.Windows.Forms.RichTextBox();
            this.txtBoxBalance = new System.Windows.Forms.TextBox();
            this.txtBoxHoverText = new System.Windows.Forms.RichTextBox();
            this.toolTipListOfGames = new System.Windows.Forms.ToolTip(this.components);
            this.btnChanceAcc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxWelcome
            // 
            this.txtBoxWelcome.AccessibleName = "";
            this.txtBoxWelcome.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxWelcome.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtBoxWelcome.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxWelcome.Location = new System.Drawing.Point(159, 28);
            this.txtBoxWelcome.Name = "txtBoxWelcome";
            this.txtBoxWelcome.Size = new System.Drawing.Size(260, 41);
            this.txtBoxWelcome.TabIndex = 1;
            this.txtBoxWelcome.Text = "Welcome to Balski";
            // 
            // txtBoxYourBalance
            // 
            this.txtBoxYourBalance.AccessibleName = "";
            this.txtBoxYourBalance.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxYourBalance.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtBoxYourBalance.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxYourBalance.Location = new System.Drawing.Point(249, 84);
            this.txtBoxYourBalance.Name = "txtBoxYourBalance";
            this.txtBoxYourBalance.Size = new System.Drawing.Size(153, 33);
            this.txtBoxYourBalance.TabIndex = 2;
            this.txtBoxYourBalance.Text = "Your balance is ";
            // 
            // txtBoxBalance
            // 
            this.txtBoxBalance.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxBalance.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBalance.Location = new System.Drawing.Point(408, 91);
            this.txtBoxBalance.Name = "txtBoxBalance";
            this.txtBoxBalance.Size = new System.Drawing.Size(88, 25);
            this.txtBoxBalance.TabIndex = 3;
            // 
            // txtBoxHoverText
            // 
            this.txtBoxHoverText.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxHoverText.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHoverText.Location = new System.Drawing.Point(133, 158);
            this.txtBoxHoverText.Name = "txtBoxHoverText";
            this.txtBoxHoverText.ReadOnly = true;
            this.txtBoxHoverText.Size = new System.Drawing.Size(341, 32);
            this.txtBoxHoverText.TabIndex = 4;
            this.txtBoxHoverText.Text = "List of games that can be purchesed";
            this.txtBoxHoverText.MouseHover += new System.EventHandler(this.txtBoxHoverText_MouseHover);
            // 
            // btnChanceAcc
            // 
            this.btnChanceAcc.BackColor = System.Drawing.SystemColors.Info;
            this.btnChanceAcc.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChanceAcc.Location = new System.Drawing.Point(27, 330);
            this.btnChanceAcc.Name = "btnChanceAcc";
            this.btnChanceAcc.Size = new System.Drawing.Size(215, 72);
            this.btnChanceAcc.TabIndex = 5;
            this.btnChanceAcc.Text = "Want to change your account? Click me !\r\n\r\n";
            this.btnChanceAcc.UseVisualStyleBackColor = false;
            this.btnChanceAcc.Click += new System.EventHandler(this.btnChanceAcc_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Info;
            this.btnExit.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(346, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(215, 72);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "\r\nWant to exit? Click me !\r\n\r\n";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(573, 430);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChanceAcc);
            this.Controls.Add(this.txtBoxHoverText);
            this.Controls.Add(this.txtBoxBalance);
            this.Controls.Add(this.txtBoxYourBalance);
            this.Controls.Add(this.txtBoxWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoxWelcome;
        private System.Windows.Forms.RichTextBox txtBoxYourBalance;
        private System.Windows.Forms.TextBox txtBoxBalance;
        private System.Windows.Forms.RichTextBox txtBoxHoverText;
        private System.Windows.Forms.ToolTip toolTipListOfGames;
        private System.Windows.Forms.Button btnChanceAcc;
        private System.Windows.Forms.Button btnExit;
    }
}

