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
using ClosedXML.Excel;



namespace edp_enrollment
{
    public partial class StudentReport : Form
    {
        public StudentReport()
        {
            InitializeComponent();
        }

        private void StudentReport_Load(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();
                string query = "SELECT student_id, first_name, last_name, email, updated_at FROM students";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();

                adapter.Fill(table);
                studreport.DataSource = table;
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

        private void LoadStudents()
        {
            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();
                string query = "SELECT student_id, first_name, last_name, email, updated_at FROM students";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();

                adapter.Fill(table);
                studreport.DataSource = table; // ✅ Display student records
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


        private void sers_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textsers.Text))
            {
                MessageBox.Show("Please enter a student ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int studentId;
            if (!int.TryParse(textsers.Text, out studentId))
            {
                MessageBox.Show("Invalid ID format. Please enter a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DBConnection db = new DBConnection();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();
                string query = "SELECT student_id, first_name, last_name, email, updated_at FROM students WHERE student_id = @studentId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@studentId", studentId);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();

                adapter.Fill(table);
                studreport.DataSource = table; // ✅ Show search result
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

        private void refres_Click(object sender, EventArgs e)
        {
            textsers.Clear(); // ✅ Clears search box
            LoadStudents();
        }

        private void export_btn_Click(object sender, EventArgs e)
        {
            if (studreport.Rows.Count == 0)
            {
                MessageBox.Show("No records to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Student Report");

            // ✅ Adding column headers
            worksheet.Cell(1, 1).Value = "Student ID";
            worksheet.Cell(1, 2).Value = "First Name";
            worksheet.Cell(1, 3).Value = "Last Name";
            worksheet.Cell(1, 4).Value = "Email";
            worksheet.Cell(1, 5).Value = "Updated At";

            // ✅ Populating data from DataGridView
            for (int i = 0; i < studreport.Rows.Count; i++)
            {
                worksheet.Cell(i + 2, 1).Value = studreport.Rows[i].Cells["student_id"].Value?.ToString();
                worksheet.Cell(i + 2, 2).Value = studreport.Rows[i].Cells["first_name"].Value?.ToString();
                worksheet.Cell(i + 2, 3).Value = studreport.Rows[i].Cells["last_name"].Value?.ToString();
                worksheet.Cell(i + 2, 4).Value = studreport.Rows[i].Cells["email"].Value?.ToString();
                worksheet.Cell(i + 2, 5).Value = studreport.Rows[i].Cells["updated_at"].Value?.ToString();
            }

            // ✅ Save the file
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Student_Report.xlsx";
            workbook.SaveAs(filePath);

            MessageBox.Show("Student report generated successfully!\nSaved to Desktop.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

