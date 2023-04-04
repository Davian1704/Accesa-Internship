
namespace Frontend
{
    partial class Login
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userTB = new System.Windows.Forms.TextBox();
            this.passTB = new System.Windows.Forms.TextBox();
            this.loginBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(257, 93);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(61, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username: ";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(257, 151);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(59, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password: ";
            // 
            // userTB
            // 
            this.userTB.Location = new System.Drawing.Point(324, 90);
            this.userTB.Name = "userTB";
            this.userTB.Size = new System.Drawing.Size(100, 20);
            this.userTB.TabIndex = 2;
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(324, 148);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(100, 20);
            this.passTB.TabIndex = 3;
            // 
            // loginBt
            // 
            this.loginBt.Location = new System.Drawing.Point(334, 203);
            this.loginBt.Name = "loginBt";
            this.loginBt.Size = new System.Drawing.Size(75, 23);
            this.loginBt.TabIndex = 8;
            this.loginBt.Text = "Login";
            this.loginBt.UseVisualStyleBackColor = true;
            this.loginBt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginBt);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.userTB);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox userTB;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Button loginBt;
    }
}

