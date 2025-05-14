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
    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();
        }

        private void logsback_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backlogs_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard back8 = new Dashboard();
            back8.Show();
        }
    }
}
