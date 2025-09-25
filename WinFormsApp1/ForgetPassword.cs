using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Enter your username.");
                return;
            }

            // Pass the username into ResetPassword
            ResetPassword resetPassword = new ResetPassword(username);
            resetPassword.Show();

            //ChangePassword cp = new ChangePassword(username);
            //cp.Show();
        }

    }
}



