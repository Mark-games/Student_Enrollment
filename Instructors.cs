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
    public partial class Instructors : Form
    {
        public Instructors()
        {
            InitializeComponent();
        }

        private void back4_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard back4 = new Dashboard();
            back4.Show();
        }

        private void close6_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
