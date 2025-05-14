namespace edp_enrollment
{
    partial class Enrollees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enrollees));
            this.panel1 = new System.Windows.Forms.Panel();
            this.back2_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.close4_btn = new System.Windows.Forms.Button();
            this.Enrollments = new System.Windows.Forms.DataGridView();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.cbStud = new System.Windows.Forms.ComboBox();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.Students_drp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enrolll_btn = new System.Windows.Forms.Button();
            this.delete_btn2 = new System.Windows.Forms.Button();
            this.searchbar_box = new System.Windows.Forms.TextBox();
            this.search_btn2 = new System.Windows.Forms.Button();
            this.refresh_btn2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Enrollments)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(204)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.back2_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.close4_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 38);
            this.panel1.TabIndex = 0;
            // 
            // back2_btn
            // 
            this.back2_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back2_btn.BackgroundImage")));
            this.back2_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.back2_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.back2_btn.FlatAppearance.BorderSize = 0;
            this.back2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back2_btn.Location = new System.Drawing.Point(0, 0);
            this.back2_btn.Name = "back2_btn";
            this.back2_btn.Size = new System.Drawing.Size(75, 38);
            this.back2_btn.TabIndex = 2;
            this.back2_btn.UseVisualStyleBackColor = true;
            this.back2_btn.Click += new System.EventHandler(this.back2_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(283, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enrollees Page";
            // 
            // close4_btn
            // 
            this.close4_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close4_btn.BackgroundImage")));
            this.close4_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close4_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.close4_btn.FlatAppearance.BorderSize = 0;
            this.close4_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close4_btn.Location = new System.Drawing.Point(677, 0);
            this.close4_btn.Name = "close4_btn";
            this.close4_btn.Size = new System.Drawing.Size(75, 38);
            this.close4_btn.TabIndex = 0;
            this.close4_btn.UseVisualStyleBackColor = true;
            this.close4_btn.Click += new System.EventHandler(this.close4_btn_Click);
            // 
            // Enrollments
            // 
            this.Enrollments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Enrollments.Location = new System.Drawing.Point(13, 111);
            this.Enrollments.Name = "Enrollments";
            this.Enrollments.Size = new System.Drawing.Size(727, 384);
            this.Enrollments.TabIndex = 1;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // cbStud
            // 
            this.cbStud.FormattingEnabled = true;
            this.cbStud.Location = new System.Drawing.Point(12, 44);
            this.cbStud.Name = "cbStud";
            this.cbStud.Size = new System.Drawing.Size(195, 21);
            this.cbStud.TabIndex = 2;
            this.cbStud.SelectedIndexChanged += new System.EventHandler(this.cbStud_SelectedIndexChanged);
            // 
            // cbCourse
            // 
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(12, 84);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(195, 21);
            this.cbCourse.TabIndex = 3;
            this.cbCourse.SelectedIndexChanged += new System.EventHandler(this.cbCourse_SelectedIndexChanged);
            // 
            // Students_drp
            // 
            this.Students_drp.AutoSize = true;
            this.Students_drp.Location = new System.Drawing.Point(214, 45);
            this.Students_drp.Name = "Students_drp";
            this.Students_drp.Size = new System.Drawing.Size(66, 13);
            this.Students_drp.TabIndex = 4;
            this.Students_drp.Text = "Students(ID)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Course";
            // 
            // enrolll_btn
            // 
            this.enrolll_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.enrolll_btn.Location = new System.Drawing.Point(287, 81);
            this.enrolll_btn.Name = "enrolll_btn";
            this.enrolll_btn.Size = new System.Drawing.Size(75, 23);
            this.enrolll_btn.TabIndex = 6;
            this.enrolll_btn.Text = "Enroll";
            this.enrolll_btn.UseVisualStyleBackColor = false;
            this.enrolll_btn.Click += new System.EventHandler(this.enrolll_btn_Click);
            // 
            // delete_btn2
            // 
            this.delete_btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delete_btn2.Location = new System.Drawing.Point(381, 82);
            this.delete_btn2.Name = "delete_btn2";
            this.delete_btn2.Size = new System.Drawing.Size(75, 23);
            this.delete_btn2.TabIndex = 7;
            this.delete_btn2.Text = "Delete";
            this.delete_btn2.UseVisualStyleBackColor = false;
            this.delete_btn2.Click += new System.EventHandler(this.delete_btn2_Click);
            // 
            // searchbar_box
            // 
            this.searchbar_box.Location = new System.Drawing.Point(473, 84);
            this.searchbar_box.Name = "searchbar_box";
            this.searchbar_box.Size = new System.Drawing.Size(181, 20);
            this.searchbar_box.TabIndex = 8;
            // 
            // search_btn2
            // 
            this.search_btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.search_btn2.Location = new System.Drawing.Point(660, 84);
            this.search_btn2.Name = "search_btn2";
            this.search_btn2.Size = new System.Drawing.Size(75, 23);
            this.search_btn2.TabIndex = 9;
            this.search_btn2.Text = "Search";
            this.search_btn2.UseVisualStyleBackColor = false;
            this.search_btn2.Click += new System.EventHandler(this.search_btn2_Click);
            // 
            // refresh_btn2
            // 
            this.refresh_btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.refresh_btn2.Location = new System.Drawing.Point(287, 52);
            this.refresh_btn2.Name = "refresh_btn2";
            this.refresh_btn2.Size = new System.Drawing.Size(75, 23);
            this.refresh_btn2.TabIndex = 10;
            this.refresh_btn2.Text = "Refresh";
            this.refresh_btn2.UseVisualStyleBackColor = false;
            this.refresh_btn2.Click += new System.EventHandler(this.refresh_btn2_Click);
            // 
            // Enrollees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 507);
            this.Controls.Add(this.refresh_btn2);
            this.Controls.Add(this.search_btn2);
            this.Controls.Add(this.searchbar_box);
            this.Controls.Add(this.delete_btn2);
            this.Controls.Add(this.enrolll_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Students_drp);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.cbStud);
            this.Controls.Add(this.Enrollments);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Enrollees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrollees";
            this.Load += new System.EventHandler(this.Enrollees_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Enrollments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close4_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back2_btn;
        private System.Windows.Forms.DataGridView Enrollments;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.ComboBox cbStud;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.Label Students_drp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enrolll_btn;
        private System.Windows.Forms.Button delete_btn2;
        private System.Windows.Forms.TextBox searchbar_box;
        private System.Windows.Forms.Button search_btn2;
        private System.Windows.Forms.Button refresh_btn2;
    }
}