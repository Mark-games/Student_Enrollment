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
    public partial class Classes : Form
    {
        public Classes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void back5_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard back3 = new Dashboard();
            back3.Show();
        }
    }
}
