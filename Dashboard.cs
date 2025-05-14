using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edp_enrollment
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void close_btn2_Click(object sender, EventArgs e)
        {
            Close();
        }
      
        private void summary_btn_Click_1(object sender, EventArgs e)
        {
            Summary sum = new Summary();
            sum.Show();
            this.Hide();
        }

        private void enrollees_btn_Click(object sender, EventArgs e)
        {
            Enrollees en = new Enrollees();
            en.Show();
            this.Hide();
        }

        private void classes_btn_Click(object sender, EventArgs e)
        {
            Classes myclass = new Classes();
            myclass.Show();
            this.Hide();
        }

        private void instructors_btn_Click(object sender, EventArgs e)
        {
            Instructors myIns = new Instructors();
            myIns.Show();
            this.Hide();
        }

        private void departments_btn_Click(object sender, EventArgs e)
        {
            Departments dept = new Departments();
            dept.Show();
            this.Hide();
        }

        private void courses_btn_Click(object sender, EventArgs e)
        {
            Courses myCor = new Courses();
            myCor.Show();
            this.Hide();
        }

        private void grades_btn_Click(object sender, EventArgs e)
        {
            Grades myGra = new Grades();
            myGra.Show();
            this.Hide();
        }

        private void students_btn_Click(object sender, EventArgs e)
        {
            StudentReport myStud = new StudentReport();
            myStud.Show();
            this.Hide();
        }

        private void logs_btn_Click(object sender, EventArgs e)
        {
            Logs myLo = new Logs();
            myLo.Show();
            this.Hide();
        }

        private void archive_btn_Click(object sender, EventArgs e)
        {
            Archived_Logs myArch = new Archived_Logs();
            myArch.Show();
            this.Hide();
        }

        private void Users_list_Click(object sender, EventArgs e)
        {
            UsersPage users = new UsersPage();
            users.Show();
            this.Hide();
        }
    }
}
