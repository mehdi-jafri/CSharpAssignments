using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CustomerEntry: Form
    {
        // Adjust your connection string
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyTestDB;Integrated Security=True";

        public CustomerEntry()
        {
            InitializeComponent();
        }

        private void btnSendInformation_Click(object sender, EventArgs e)
        {
            // Check if the checkbox is ticked
            if (!checkBox1.Checked)  // Replace checkBox1 with your checkbox name
            {
                MessageBox.Show("Please check the agreement before submitting.", "Agreement Required",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop further execution
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"INSERT INTO CustomerMaster
                                    (Title, FirstName, Initials, LastName, StreetAddress, StreetAddress2, 
                                     Region, City, PostalCode, Country, CustomerPhone, CustomerFax, CustomerDOB, CustomerEmail)
                                     VALUES
                                    (@Title, @FirstName, @Initials, @LastName, @StreetAddress, @StreetAddress2, 
                                     @Region, @City, @PostalCode, @Country, @CustomerPhone, @CustomerFax, @CustomerDOB, @CustomerEmail)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Map fields from your form
                        cmd.Parameters.AddWithValue("@Title", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@FirstName", textBox4.Text.Trim());
                        cmd.Parameters.AddWithValue("@Initials", textBox3.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", textBox2.Text.Trim());
                        cmd.Parameters.AddWithValue("@StreetAddress", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@StreetAddress2", textBox5.Text.Trim());
                        cmd.Parameters.AddWithValue("@Region", textBox7.Text.Trim());
                        cmd.Parameters.AddWithValue("@City", textBox6.Text.Trim());
                        cmd.Parameters.AddWithValue("@PostalCode", textBox8.Text.Trim());
                        cmd.Parameters.AddWithValue("@Country", comboBox2.Text);
                        cmd.Parameters.AddWithValue("@CustomerPhone", textBox9.Text.Trim());
                        cmd.Parameters.AddWithValue("@CustomerFax", textBox10.Text.Trim());
                        cmd.Parameters.AddWithValue("@CustomerDOB", dateTimePicker1.Value.Date);
                        cmd.Parameters.AddWithValue("@CustomerEmail", textBox11.Text.Trim());

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                            MessageBox.Show("Customer saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Insert failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Clear fields after saving
                comboBox1.SelectedIndex = -1;
                textBox4.Clear();
                textBox3.Clear();
                textBox2.Clear();
                textBox1.Clear();
                textBox5.Clear();
                textBox7.Clear();
                textBox6.Clear();
                textBox8.Clear();
                comboBox2.SelectedIndex = -1;
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                dateTimePicker1.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
