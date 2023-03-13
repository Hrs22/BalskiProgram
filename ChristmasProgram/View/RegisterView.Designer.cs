namespace ChristmasProgram.View
{
    partial class RegisterView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterView));
            this.txtBoxGetStarted = new System.Windows.Forms.RichTextBox();
            this.txtBoxInfo = new System.Windows.Forms.RichTextBox();
            this.txtBoxHoverText = new System.Windows.Forms.RichTextBox();
            this.toolTipLearnThis = new System.Windows.Forms.ToolTip(this.components);
            this.txtBoxEnterEmail = new System.Windows.Forms.RichTextBox();
            this.txtBoxEnterPassword = new System.Windows.Forms.RichTextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.toolTipEmail = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPassword = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtBoxGetStarted
            // 
            this.txtBoxGetStarted.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxGetStarted.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxGetStarted.Location = new System.Drawing.Point(120, 99);
            this.txtBoxGetStarted.Name = "txtBoxGetStarted";
            this.txtBoxGetStarted.ReadOnly = true;
            this.txtBoxGetStarted.Size = new System.Drawing.Size(222, 48);
            this.txtBoxGetStarted.TabIndex = 0;
            this.txtBoxGetStarted.Text = " Get Started";
            // 
            // txtBoxInfo
            // 
            this.txtBoxInfo.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxInfo.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInfo.Location = new System.Drawing.Point(53, 163);
            this.txtBoxInfo.Name = "txtBoxInfo";
            this.txtBoxInfo.ReadOnly = true;
            this.txtBoxInfo.Size = new System.Drawing.Size(334, 56);
            this.txtBoxInfo.TabIndex = 1;
            this.txtBoxInfo.Text = "Let\'s verify some information about you to help set up your account.";
            // 
            // txtBoxHoverText
            // 
            this.txtBoxHoverText.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxHoverText.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHoverText.Location = new System.Drawing.Point(191, 225);
            this.txtBoxHoverText.Name = "txtBoxHoverText";
            this.txtBoxHoverText.ReadOnly = true;
            this.txtBoxHoverText.Size = new System.Drawing.Size(213, 26);
            this.txtBoxHoverText.TabIndex = 2;
            this.txtBoxHoverText.Text = "Learn why we need this.";
            this.txtBoxHoverText.MouseHover += new System.EventHandler(this.txtBoxHoverText_MouseHover);
            // 
            // toolTipLearnThis
            // 
            this.toolTipLearnThis.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // txtBoxEnterEmail
            // 
            this.txtBoxEnterEmail.AccessibleName = "";
            this.txtBoxEnterEmail.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxEnterEmail.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtBoxEnterEmail.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEnterEmail.Location = new System.Drawing.Point(111, 308);
            this.txtBoxEnterEmail.Name = "txtBoxEnterEmail";
            this.txtBoxEnterEmail.Size = new System.Drawing.Size(221, 30);
            this.txtBoxEnterEmail.TabIndex = 3;
            this.txtBoxEnterEmail.Text = "      Enter email ";
            this.txtBoxEnterEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxEnterEmail_MouseClick);
            this.txtBoxEnterEmail.MouseHover += new System.EventHandler(this.txtBoxEnterEmail_MouseHover);
            // 
            // txtBoxEnterPassword
            // 
            this.txtBoxEnterPassword.AccessibleName = "";
            this.txtBoxEnterPassword.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxEnterPassword.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtBoxEnterPassword.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEnterPassword.Location = new System.Drawing.Point(111, 381);
            this.txtBoxEnterPassword.Name = "txtBoxEnterPassword";
            this.txtBoxEnterPassword.Size = new System.Drawing.Size(221, 30);
            this.txtBoxEnterPassword.TabIndex = 4;
            this.txtBoxEnterPassword.Tag = "";
            this.txtBoxEnterPassword.Text = "    Enter Password";
            this.txtBoxEnterPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxEnterPassword_MouseClick);
            this.txtBoxEnterPassword.MouseHover += new System.EventHandler(this.txtBoxEnterPassword_MouseHover);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.Info;
            this.btnRegister.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(78, 474);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(274, 48);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(436, 672);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtBoxEnterPassword);
            this.Controls.Add(this.txtBoxEnterEmail);
            this.Controls.Add(this.txtBoxHoverText);
            this.Controls.Add(this.txtBoxInfo);
            this.Controls.Add(this.txtBoxGetStarted);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoxGetStarted;
        private System.Windows.Forms.RichTextBox txtBoxInfo;
        private System.Windows.Forms.RichTextBox txtBoxHoverText;
        private System.Windows.Forms.ToolTip toolTipLearnThis;
        private System.Windows.Forms.RichTextBox txtBoxEnterEmail;
        private System.Windows.Forms.RichTextBox txtBoxEnterPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ToolTip toolTipEmail;
        private System.Windows.Forms.ToolTip toolTipPassword;
    }
}