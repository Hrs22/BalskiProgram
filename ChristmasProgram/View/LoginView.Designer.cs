namespace ChristmasProgram.View
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.txtBoxEmail = new System.Windows.Forms.RichTextBox();
            this.txtBoxPassword = new System.Windows.Forms.RichTextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.btnCantLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.AccessibleName = "";
            this.txtBoxEmail.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxEmail.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtBoxEmail.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(61, 120);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(221, 30);
            this.txtBoxEmail.TabIndex = 0;
            this.txtBoxEmail.Text = "    Email or phone";
            this.txtBoxEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxEmail_MouseClick);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.AccessibleName = "";
            this.txtBoxPassword.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxPassword.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtBoxPassword.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.Location = new System.Drawing.Point(61, 200);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(221, 30);
            this.txtBoxPassword.TabIndex = 1;
            this.txtBoxPassword.Text = "       Password";
            this.txtBoxPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxPassword_MouseClick);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.SystemColors.Info;
            this.btnLogIn.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(34, 275);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(274, 48);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.BackColor = System.Drawing.SystemColors.Info;
            this.btnCreateAcc.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAcc.Location = new System.Drawing.Point(48, 381);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(247, 71);
            this.btnCreateAcc.TabIndex = 3;
            this.btnCreateAcc.Text = "Dont have a Balski Account? \r\nCreate a free Account just a click away!!!\r\n";
            this.btnCreateAcc.UseVisualStyleBackColor = false;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // btnCantLog
            // 
            this.btnCantLog.BackColor = System.Drawing.SystemColors.Info;
            this.btnCantLog.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantLog.Location = new System.Drawing.Point(98, 477);
            this.btnCantLog.Name = "btnCantLog";
            this.btnCantLog.Size = new System.Drawing.Size(148, 36);
            this.btnCantLog.TabIndex = 4;
            this.btnCantLog.Text = "Can\'t log in?";
            this.btnCantLog.UseVisualStyleBackColor = false;
            this.btnCantLog.Click += new System.EventHandler(this.btnCantLog_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(329, 569);
            this.Controls.Add(this.btnCantLog);
            this.Controls.Add(this.btnCreateAcc);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxEmail);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoxEmail;
        private System.Windows.Forms.RichTextBox txtBoxPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.Button btnCantLog;
    }
}