
namespace Frontend
{
    partial class Challenge
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
            this.completeBtn = new System.Windows.Forms.Button();
            this.descriptionTb = new System.Windows.Forms.TextBox();
            this.titleTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // completeBtn
            // 
            this.completeBtn.Location = new System.Drawing.Point(349, 381);
            this.completeBtn.Name = "completeBtn";
            this.completeBtn.Size = new System.Drawing.Size(84, 23);
            this.completeBtn.TabIndex = 5;
            this.completeBtn.Text = "Completed";
            this.completeBtn.UseVisualStyleBackColor = true;
            this.completeBtn.Click += new System.EventHandler(this.completeBtn_Click);
            // 
            // descriptionTb
            // 
            this.descriptionTb.Location = new System.Drawing.Point(235, 108);
            this.descriptionTb.Multiline = true;
            this.descriptionTb.Name = "descriptionTb";
            this.descriptionTb.Size = new System.Drawing.Size(296, 215);
            this.descriptionTb.TabIndex = 4;
            // 
            // titleTb
            // 
            this.titleTb.Location = new System.Drawing.Point(235, 37);
            this.titleTb.Name = "titleTb";
            this.titleTb.Size = new System.Drawing.Size(296, 20);
            this.titleTb.TabIndex = 3;
            // 
            // Challenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.completeBtn);
            this.Controls.Add(this.descriptionTb);
            this.Controls.Add(this.titleTb);
            this.Name = "Challenge";
            this.Text = "Challenge";
            this.Load += new System.EventHandler(this.Challenge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button completeBtn;
        private System.Windows.Forms.TextBox descriptionTb;
        private System.Windows.Forms.TextBox titleTb;
    }
}