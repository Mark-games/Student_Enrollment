namespace edp_enrollment
{
    partial class Instructors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructors));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.back4_btn = new System.Windows.Forms.Button();
            this.close6_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(204)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.back4_btn);
            this.panel1.Controls.Add(this.close6_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 38);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(291, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Instructors Page";
            // 
            // back4_btn
            // 
            this.back4_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back4_btn.BackgroundImage")));
            this.back4_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.back4_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back4_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.back4_btn.FlatAppearance.BorderSize = 0;
            this.back4_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back4_btn.Location = new System.Drawing.Point(0, 0);
            this.back4_btn.Name = "back4_btn";
            this.back4_btn.Size = new System.Drawing.Size(75, 38);
            this.back4_btn.TabIndex = 1;
            this.back4_btn.UseVisualStyleBackColor = true;
            this.back4_btn.Click += new System.EventHandler(this.back4_btn_Click);
            // 
            // close6_btn
            // 
            this.close6_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close6_btn.BackgroundImage")));
            this.close6_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close6_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close6_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.close6_btn.FlatAppearance.BorderSize = 0;
            this.close6_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close6_btn.Location = new System.Drawing.Point(661, 0);
            this.close6_btn.Name = "close6_btn";
            this.close6_btn.Size = new System.Drawing.Size(75, 38);
            this.close6_btn.TabIndex = 0;
            this.close6_btn.UseVisualStyleBackColor = true;
            this.close6_btn.Click += new System.EventHandler(this.close6_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 365);
            this.dataGridView1.TabIndex = 1;
            // 
            // Instructors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 468);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Instructors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instructors";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close6_btn;
        private System.Windows.Forms.Button back4_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}