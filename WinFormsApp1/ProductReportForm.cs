using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class ProductReportForm : Form
    {
        public ProductReportForm()
        {
            InitializeComponent();
        }

        private void ProductReportForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyTestDB;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();

                    string query = "SELECT ProductID, ProductName, Price, Quantity, Description FROM ProductMaster";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridView1.DataSource = dt;  // ✅ Bind to DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠ Error: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();  // reload products
        }
    }
}
