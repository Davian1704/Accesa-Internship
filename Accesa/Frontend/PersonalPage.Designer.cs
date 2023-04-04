
namespace Frontend
{
    partial class PersonalPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameL = new System.Windows.Forms.Label();
            this.tokensL = new System.Windows.Forms.Label();
            this.tokensVal = new System.Windows.Forms.Label();
            this.addNew = new System.Windows.Forms.Button();
            this.hostedCh = new System.Windows.Forms.ListBox();
            this.otherCh = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Challenges Hosted";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Other Active Challenges";
            // 
            // usernameL
            // 
            this.usernameL.AutoSize = true;
            this.usernameL.Location = new System.Drawing.Point(656, 9);
            this.usernameL.Name = "usernameL";
            this.usernameL.Size = new System.Drawing.Size(0, 13);
            this.usernameL.TabIndex = 4;
            // 
            // tokensL
            // 
            this.tokensL.AutoSize = true;
            this.tokensL.Location = new System.Drawing.Point(656, 22);
            this.tokensL.Name = "tokensL";
            this.tokensL.Size = new System.Drawing.Size(49, 13);
            this.tokensL.TabIndex = 5;
            this.tokensL.Text = "Tokens: ";
            // 
            // tokensVal
            // 
            this.tokensVal.AutoSize = true;
            this.tokensVal.Location = new System.Drawing.Point(725, 22);
            this.tokensVal.Name = "tokensVal";
            this.tokensVal.Size = new System.Drawing.Size(0, 13);
            this.tokensVal.TabIndex = 6;
            // 
            // addNew
            // 
            this.addNew.Location = new System.Drawing.Point(609, 104);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(110, 23);
            this.addNew.TabIndex = 7;
            this.addNew.Text = "New Challenge";
            this.addNew.UseVisualStyleBackColor = true;
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
            // 
            // hostedCh
            // 
            this.hostedCh.FormattingEnabled = true;
            this.hostedCh.Location = new System.Drawing.Point(70, 104);
            this.hostedCh.Name = "hostedCh";
            this.hostedCh.Size = new System.Drawing.Size(120, 329);
            this.hostedCh.TabIndex = 8;
            // 
            // otherCh
            // 
            this.otherCh.FormattingEnabled = true;
            this.otherCh.Location = new System.Drawing.Point(351, 104);
            this.otherCh.Name = "otherCh";
            this.otherCh.Size = new System.Drawing.Size(137, 329);
            this.otherCh.TabIndex = 9;
            this.otherCh.SelectedIndexChanged += new System.EventHandler(this.otherCh_SelectedIndexChanged);
            // 
            // PersonalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.otherCh);
            this.Controls.Add(this.hostedCh);
            this.Controls.Add(this.addNew);
            this.Controls.Add(this.tokensVal);
            this.Controls.Add(this.tokensL);
            this.Controls.Add(this.usernameL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PersonalPage";
            this.Text = "PersonalPage";
            this.Load += new System.EventHandler(this.PersonalPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usernameL;
        private System.Windows.Forms.Label tokensL;
        private System.Windows.Forms.Label tokensVal;
        private System.Windows.Forms.Button addNew;
        private System.Windows.Forms.ListBox hostedCh;
        private System.Windows.Forms.ListBox otherCh;
    }
}