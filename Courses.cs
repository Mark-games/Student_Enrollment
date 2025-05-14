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
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();
        }

        private void cloe_course_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backCourse_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard back6 = new Dashboard();
            back6.Show();
        }
    }
}
