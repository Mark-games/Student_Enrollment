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
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            // Check if passwords match before proceeding
            if (password_create.Text.Trim() != confirmpass.Text.Trim())
            {
                MessageBox.Show("Passwords do not match! Please re-enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stops execution if passwords are different
            }

            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();
                string query = "INSERT INTO users (username, password) VALUES (@username, SHA2(@password, 256))"; // Encrypt password
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username_create.Text.Trim());
                cmd.Parameters.AddWithValue("@password", password_create.Text.Trim());

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close registration form after success
                }
                else
                {
                    MessageBox.Show("Failed to create account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
    }
}
