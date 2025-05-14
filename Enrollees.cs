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
    public partial class Enrollees : Form
    {
        public Enrollees()
        {
            InitializeComponent();
        }

        private void close4_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back2_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard back2 = new Dashboard();
            back2.Show();
        }

        private void Enrollees_Load(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();
                string query = "SELECT enrollment_id, student_id, course_id, enrollment_date FROM enrollments";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();

                adapter.Fill(table);
                Enrollments.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            LoadEnrollments();
            LoadStudents(); 
            LoadCourses();

        }

        private void LoadEnrollments()
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();
                string query = "SELECT enrollment_id, student_id, course_id, enrollment_date FROM enrollments";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();

                adapter.Fill(table);
                Enrollments.DataSource = table; // ✅ Bind data to DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            
            LoadStudents();
            LoadCourses();

        }

        private void LoadStudents()
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();
                string query = "SELECT student_id, student_id FROM students";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();

                adapter.Fill(table);

                // ✅ Ensure the dropdown gets data
                cbStud.DataSource = table;
                cbStud.DisplayMember = "student_id";
                cbStud.ValueMember = "student_id";
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

        private void LoadCourses()
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();
                string query = "SELECT course_id, course_name FROM courses"; // ✅ Fetch courses
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();

                adapter.Fill(table);
                cbCourse.DataSource = table; // ✅ Bind data to ComboBox
                cbCourse.DisplayMember = "course_name"; // Show course names
                cbCourse.ValueMember = "course_id"; // Store course IDs
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

        private void enrolll_btn_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();
                string query = "INSERT INTO enrollments (student_id, course_id) VALUES (@studentId, @courseId)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@studentId", cbStud.SelectedValue); // ✅ Get student ID from dropdown
                cmd.Parameters.AddWithValue("@courseId", cbCourse.SelectedValue); // Get course ID from dropdown

                cmd.ExecuteNonQuery();
                MessageBox.Show("Enrollment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadEnrollments(); // ✅ Refresh the list
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

        private void delete_btn2_Click(object sender, EventArgs e)
        {
            if (Enrollments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an enrollment to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Show confirmation dialog before deleting
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this enrollment?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult != DialogResult.Yes)
            {
                return; 
            }

            int enrollmentId = Convert.ToInt32(Enrollments.SelectedRows[0].Cells["enrollment_id"].Value);

            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM enrollments WHERE enrollment_id = @enrollmentId", conn);
                cmd.Parameters.AddWithValue("@enrollmentId", enrollmentId);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Enrollment removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEnrollments(); // ✅ Refresh DataGridView after deletion
                }
                else
                {
                    MessageBox.Show("Deletion failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cbStud_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStud.SelectedIndex == -1) return; // ✅ Ignore filtering until a selection is made

            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();
                string query = "SELECT enrollment_id, student_id, course_id, enrollment_date FROM enrollments WHERE student_id = @studentId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@studentId", cbStud.SelectedValue); // ✅ Apply filtering

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();

                adapter.Fill(table);
                Enrollments.DataSource = table; // ✅ Show filtered results
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

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCourse.SelectedIndex == -1) return; // ✅ Ignore filtering until a selection is made

            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();
                string query = "SELECT enrollment_id, student_id, course_id, enrollment_date FROM enrollments WHERE course_id = @courseId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@courseId", cbCourse.SelectedValue); // ✅ Apply filtering based on course

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();

                adapter.Fill(table);
                Enrollments.DataSource = table; // ✅ Show filtered results
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

        private void refresh_btn2_Click(object sender, EventArgs e)
        {
            LoadEnrollments(); 
            cbStud.SelectedIndex = -1; 
            cbCourse.SelectedIndex = -1;
        }

        private void search_btn2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchbar_box.Text))
            {
                MessageBox.Show("Please enter an enrollment ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int enrollmentId;
            if (!int.TryParse(searchbar_box.Text, out enrollmentId))
            {
                MessageBox.Show("Invalid ID format. Please enter a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();
                string query = "SELECT enrollment_id, student_id, course_id, enrollment_date FROM enrollments WHERE enrollment_id = @enrollmentId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@enrollmentId", enrollmentId);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();

                adapter.Fill(table);
                Enrollments.DataSource = table; // ✅ Show the search result
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
