using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class EmployeeEntryForm : Form
    {
        // Change this connection string to match your SQL Server
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyTestDB;Integrated Security=True";

        public EmployeeEntryForm()
        {
            InitializeComponent();
        }

        private void btnSendInformation_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "INSERT INTO EmployeeMaster " +
                                   "(FirstName, LastName, JobPosition, Email, PhoneNumber, MobileNumber, Fax) " +
                                   "VALUES (@FirstName, @LastName, @JobPosition, @Email, @PhoneNumber, @MobileNumber, @Fax)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Map textboxes
                        cmd.Parameters.AddWithValue("@FirstName", textBox10.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", textBox8.Text.Trim());
                        cmd.Parameters.AddWithValue("@JobPosition", textBox5.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@PhoneNumber", textBox2.Text.Trim());
                        cmd.Parameters.AddWithValue("@MobileNumber", textBox3.Text.Trim());
                        cmd.Parameters.AddWithValue("@Fax", textBox4.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Employee information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear fields after saving
                textBox10.Clear();
                textBox8.Clear();
                textBox5.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }
    }
}