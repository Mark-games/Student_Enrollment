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
    public partial class Archived_Logs : Form
    {
        public Archived_Logs()
        {
            InitializeComponent();
        }

        private void arch_close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void arch_back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard back9 = new Dashboard();
            back9.Show();
        }
    }
}
