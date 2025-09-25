using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ProductEntryForm : Form
    {
        public ProductEntryForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Fetch values from your controls
            string productIdText = textBox10.Text.Trim();   // Product ID (optional if auto-generated)
            string name = textBox8.Text.Trim();             // Product Name
            string priceText = textBox9.Text.Trim();        // Price
            string qtyText = comboBox1.Text.Trim();         // Quantity from ComboBox
            string desc = textBox1.Text.Trim();             // Description

            // Validation
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(priceText) || string.IsNullOrEmpty(qtyText))
            {
                MessageBox.Show("Please fill all required fields (Name, Price, Quantity).");
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price) || price <= 0)
            {
                MessageBox.Show("Enter a valid positive price.");
                return;
            }

            if (!int.TryParse(qtyText, out int qty) || qty < 0)
            {
                MessageBox.Show("Enter a valid quantity (>= 0).");
                return;
            }

            try
            {
                string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyTestDB;Integrated Security=True";

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();

                    string query = "INSERT INTO ProductMaster (ProductName, Price, Quantity, Description) " +
                                   "VALUES (@Name, @Price, @Qty, @Desc)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Price", price); 
                        cmd.Parameters.AddWithValue("@Qty", qty);
                        cmd.Parameters.AddWithValue("@Desc", desc);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("✅ Product added successfully!");
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("❌ Error inserting product.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠ Error: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            textBox10.Text = ""; // Product ID (if you allow manual entry)
            textBox8.Text = "";  // Product Name
            textBox9.Text = "";  // Price
            comboBox1.SelectedIndex = -1; // Clear Quantity
            textBox1.Text = "";  // Description
        }
    }
}
