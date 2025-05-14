namespace edp_enrollment
{
    partial class StudentReport
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
            this.studreport = new System.Windows.Forms.DataGridView();
            this.textsers = new System.Windows.Forms.TextBox();
            this.sers = new System.Windows.Forms.Button();
            this.refres = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.export_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studreport)).BeginInit();
            this.SuspendLayout();
            // 
            // studreport
            // 
            this.studreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studreport.Location = new System.Drawing.Point(12, 74);
            this.studreport.Name = "studreport";
            this.studreport.Size = new System.Drawing.Size(801, 443);
            this.studreport.TabIndex = 0;
            // 
            // textsers
            // 
            this.textsers.Location = new System.Drawing.Point(592, 48);
            this.textsers.Name = "textsers";
            this.textsers.Size = new System.Drawing.Size(140, 20);
            this.textsers.TabIndex = 1;
            // 
            // sers
            // 
            this.sers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sers.Location = new System.Drawing.Point(738, 45);
            this.sers.Name = "sers";
            this.sers.Size = new System.Drawing.Size(75, 23);
            this.sers.TabIndex = 2;
            this.sers.Text = "Search";
            this.sers.UseVisualStyleBackColor = false;
            this.sers.Click += new System.EventHandler(this.sers_Click);
            // 
            // refres
            // 
            this.refres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.refres.Location = new System.Drawing.Point(12, 12);
            this.refres.Name = "refres";
            this.refres.Size = new System.Drawing.Size(75, 23);
            this.refres.TabIndex = 3;
            this.refres.Text = "Refresh";
            this.refres.UseVisualStyleBackColor = false;
            this.refres.Click += new System.EventHandler(this.refres_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "STUDENTS REPORTS LISTS";
            // 
            // export_btn
            // 
            this.export_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.export_btn.Location = new System.Drawing.Point(12, 45);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(75, 23);
            this.export_btn.TabIndex = 5;
            this.export_btn.Text = "Export";
            this.export_btn.UseVisualStyleBackColor = false;
            this.export_btn.Click += new System.EventHandler(this.export_btn_Click);
            // 
            // StudentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 529);
            this.Controls.Add(this.export_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refres);
            this.Controls.Add(this.sers);
            this.Controls.Add(this.textsers);
            this.Controls.Add(this.studreport);
            this.Name = "StudentReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentReport";
            this.Load += new System.EventHandler(this.StudentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studreport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studreport;
        private System.Windows.Forms.TextBox textsers;
        private System.Windows.Forms.Button sers;
        private System.Windows.Forms.Button refres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button export_btn;
    }
}