using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace WinFormsApp1
{
    public partial class ChangePassword : Form
    {
        private string username; // logged-in username
        public ChangePassword(string uname)
        {
            InitializeComponent();
            username = uname;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string oldPass = textBox1.Text.Trim();    // old password
            string newPass = textBox2.Text.Trim();    // new password
            string confirmPass = textBox3.Text.Trim(); // confirm new password

            // 1. Validation checks
            if (string.IsNullOrEmpty(oldPass) || string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("New password and confirmation do not match.");
                return;
            }

            if (newPass.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.");
                return;
            }

            try
            {
                string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyTestDB;Integrated Security=True";

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();

                    // 2. Check if old password matches
                    string checkQuery = "SELECT COUNT(*) FROM Users2 WHERE Name = @Username AND Password = @OldPassword";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", username);
                        checkCmd.Parameters.AddWithValue("@OldPassword", oldPass);

                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("Old password is incorrect.");
                            return;
                        }
                    }

                    // 3. Update with new password
                    string updateQuery = "UPDATE Users2 SET Password = @NewPassword, ConfirmPassword = @ConfirmPassword WHERE Name = @Username";

                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue("@NewPassword", newPass);
                        updateCmd.Parameters.AddWithValue("@ConfirmPassword", confirmPass);
                        updateCmd.Parameters.AddWithValue("@Username", username);

                        int rows = updateCmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Password changed successfully!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error updating password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error changing password: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}