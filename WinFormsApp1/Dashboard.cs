using System;

using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void ExitApp(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Open Product Registry Form
        private void OpenProductRegistryForm(object sender, EventArgs e)
        {
            ProductRegistryForm prf = new ProductRegistryForm();
            prf.MdiParent = this;
            prf.Show();
        }
        private void OpenProductEntryForm(object sender, EventArgs e)
        {
            ProductEntryForm pef = new ProductEntryForm();
            pef.MdiParent = this;
            pef.Show();
        }

        private void OpenProductReportForm(object sender, EventArgs e)
        {
            ProductReportForm pr = new ProductReportForm();
            pr.MdiParent = this;
            pr.Show();
        }

        // Open User Form
        private void OpenUserForm(object sender, EventArgs e)
        {
            //prevent opening the same form multiple times.
            foreach (Form child in this.MdiChildren)
            {
                if (child is UserForm)
                {
                    child.Activate(); // focus existing
                    return;
                }
            }

            UserForm uf = new UserForm();
            uf.MdiParent = this;
            uf.Show();
        }

        private void OpenCustomerEntryForm(object sender, EventArgs e)
        {
            CustomerEntry cen = new CustomerEntry();
            cen.MdiParent = this;
            cen.Show();

        }

        private void OpenCustomerReport(object sender, EventArgs e)
        {
            CustomerReport cr = new CustomerReport();
            cr.MdiParent = this;
            cr.Show();
        }

        private void OpenEmployeeEntry(object sender, EventArgs e)
        {
            EmployeeEntryForm ef = new EmployeeEntryForm();
            ef.MdiParent = this;
            ef.Show();
        }

        private void OpneEmployeeReport(object sender, EventArgs e)
        {
            EmployeeReport er =new EmployeeReport();
            er.MdiParent = this;
            er.Show();
        }
    }
}
