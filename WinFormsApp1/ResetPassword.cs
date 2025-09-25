using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ResetPassword : Form
    {
        private string username; // to know whose password we are resetting

        public ResetPassword(string uname)
        {
            InitializeComponent();
            username = uname; // passed from ForgetPassword form
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // No need to throw exception. You can leave it empty or add info if needed.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newPass = textBox1.Text.Trim();
            string confirmPass = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Please enter both password fields.");
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            try
            {
                // Replace with your actual connection string
                string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyTestDB;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    string query = "UPDATE Users2 SET Password = @Password, ConfirmPassword = @ConfirmPassword WHERE Name = @Username";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Password", newPass);
                        cmd.Parameters.AddWithValue("@ConfirmPassword", confirmPass);
                        cmd.Parameters.AddWithValue("@Username", username);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Password reset successfully!");
                            this.Close(); // close reset form
                            Login loginForm = new Login();
                            loginForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Error: Could not reset password. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error resetting password: " + ex.Message);
            }
        }
    }
}
