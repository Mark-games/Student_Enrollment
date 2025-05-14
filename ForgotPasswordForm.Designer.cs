namespace edp_enrollment
{
    partial class ForgotPasswordForm
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
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newpass_word = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resetpass_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(55, 82);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(327, 20);
            this.username.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Username:";
            // 
            // newpass_word
            // 
            this.newpass_word.Location = new System.Drawing.Point(55, 148);
            this.newpass_word.Name = "newpass_word";
            this.newpass_word.PasswordChar = '*';
            this.newpass_word.Size = new System.Drawing.Size(327, 20);
            this.newpass_word.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Password:";
            // 
            // resetpass_btn
            // 
            this.resetpass_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resetpass_btn.ForeColor = System.Drawing.Color.White;
            this.resetpass_btn.Location = new System.Drawing.Point(58, 229);
            this.resetpass_btn.Name = "resetpass_btn";
            this.resetpass_btn.Size = new System.Drawing.Size(324, 65);
            this.resetpass_btn.TabIndex = 4;
            this.resetpass_btn.Text = "RESET PASSWORD";
            this.resetpass_btn.UseVisualStyleBackColor = false;
            this.resetpass_btn.Click += new System.EventHandler(this.resetpass_btn_Click);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 341);
            this.Controls.Add(this.resetpass_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newpass_word);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username);
            this.Name = "ForgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newpass_word;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetpass_btn;
    }
}