using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace edp_enrollment
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void resetpass_btn_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();

                // Check if username exists
                string checkUserQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
                MySqlCommand checkCmd = new MySqlCommand(checkUserQuery, conn);
                checkCmd.Parameters.AddWithValue("@username", username.Text.Trim());

                int userExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (userExists > 0) // If username exists, update password
                {
                    string updatePasswordQuery = "UPDATE users SET password = SHA2(@newPassword, 256) WHERE username = @username";
                    MySqlCommand updateCmd = new MySqlCommand(updatePasswordQuery, conn);
                    updateCmd.Parameters.AddWithValue("@username", username.Text.Trim());
                    updateCmd.Parameters.AddWithValue("@newPassword", newpass_word.Text.Trim());

                    int result = updateCmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Password reset successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Close form after success
                    }
                    else
                    {
                        MessageBox.Show("Failed to reset password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Username not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
