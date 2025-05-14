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
    public partial class Departments : Form
    {
        public Departments()
        {
            InitializeComponent();
        }

        private void close7_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void back5_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard back5 = new Dashboard();
            back5.Show();
        }
    }
}
