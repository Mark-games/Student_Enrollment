using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace edp_enrollment
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            
        }

        private void close9_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void studback_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard back7 = new Dashboard();
            back7.Show();
        }

        private void LoadStudentData(string studentId)
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();
                string query = "SELECT first_name, last_name, email, updated_at FROM students WHERE student_id = @studentId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@studentId", studentId);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) 
                {
                    txtStudentID.Text = studentId;
                    txtFirstName.Text = reader["first_name"].ToString();
                    txtLastName.Text = reader["last_name"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txtUpdatedAt.Text = reader["updated_at"].ToString();
                }
                else
                {
                    MessageBox.Show("No student found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Students_Load(object sender, EventArgs e)
        {

        }
    }
}
