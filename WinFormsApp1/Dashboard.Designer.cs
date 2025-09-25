namespace WinFormsApp1
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            productRegistryToolStripMenuItem = new ToolStripMenuItem();
            productEntryToolStripMenuItem1 = new ToolStripMenuItem();
            productReportToolStripMenuItem1 = new ToolStripMenuItem();
            productEntryToolStripMenuItem = new ToolStripMenuItem();
            customerReportToolStripMenuItem1 = new ToolStripMenuItem();
            customerReportToolStripMenuItem = new ToolStripMenuItem();
            employeeReportToolStripMenuItem = new ToolStripMenuItem();
            userFormToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { productRegistryToolStripMenuItem, productEntryToolStripMenuItem, customerReportToolStripMenuItem, userFormToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1425, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // productRegistryToolStripMenuItem
            // 
            productRegistryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productEntryToolStripMenuItem1, productReportToolStripMenuItem1 });
            productRegistryToolStripMenuItem.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productRegistryToolStripMenuItem.Name = "productRegistryToolStripMenuItem";
            productRegistryToolStripMenuItem.Size = new Size(185, 34);
            productRegistryToolStripMenuItem.Text = "Product Registry";
            productRegistryToolStripMenuItem.Click += OpenProductRegistryForm;
            // 
            // productEntryToolStripMenuItem1
            // 
            productEntryToolStripMenuItem1.Name = "productEntryToolStripMenuItem1";
            productEntryToolStripMenuItem1.Size = new Size(240, 34);
            productEntryToolStripMenuItem1.Text = "Product Entry";
            productEntryToolStripMenuItem1.Click += OpenProductEntryForm;
            // 
            // productReportToolStripMenuItem1
            // 
            productReportToolStripMenuItem1.Name = "productReportToolStripMenuItem1";
            productReportToolStripMenuItem1.Size = new Size(240, 34);
            productReportToolStripMenuItem1.Text = "Product Report ";
            productReportToolStripMenuItem1.Click += OpenProductReportForm;
            // 
            // productEntryToolStripMenuItem
            // 
            productEntryToolStripMenuItem.CheckOnClick = true;
            productEntryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customerReportToolStripMenuItem1 });
            productEntryToolStripMenuItem.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productEntryToolStripMenuItem.Name = "productEntryToolStripMenuItem";
            productEntryToolStripMenuItem.Size = new Size(175, 34);
            productEntryToolStripMenuItem.Text = "Customer Entry";
            productEntryToolStripMenuItem.Click += OpenCustomerEntryForm;
            // 
            // customerReportToolStripMenuItem1
            // 
            customerReportToolStripMenuItem1.Name = "customerReportToolStripMenuItem1";
            customerReportToolStripMenuItem1.Size = new Size(251, 34);
            customerReportToolStripMenuItem1.Text = "Customer Report";
            customerReportToolStripMenuItem1.Click += OpenCustomerReport;
            // 
            // customerReportToolStripMenuItem
            // 
            customerReportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { employeeReportToolStripMenuItem });
            customerReportToolStripMenuItem.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerReportToolStripMenuItem.Name = "customerReportToolStripMenuItem";
            customerReportToolStripMenuItem.Size = new Size(182, 34);
            customerReportToolStripMenuItem.Text = "Employee Entry ";
            customerReportToolStripMenuItem.Click += OpenEmployeeEntry;
            // 
            // employeeReportToolStripMenuItem
            // 
            employeeReportToolStripMenuItem.Name = "employeeReportToolStripMenuItem";
            employeeReportToolStripMenuItem.Size = new Size(252, 34);
            employeeReportToolStripMenuItem.Text = "Employee Report";
            employeeReportToolStripMenuItem.Click += OpneEmployeeReport;
            // 
            // userFormToolStripMenuItem
            // 
            userFormToolStripMenuItem.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userFormToolStripMenuItem.Name = "userFormToolStripMenuItem";
            userFormToolStripMenuItem.Size = new Size(125, 34);
            userFormToolStripMenuItem.Text = "User Form";
            userFormToolStripMenuItem.Click += OpenUserForm;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(60, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitApp;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1425, 623);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Text = "Dashboard";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem productRegistryToolStripMenuItem;
        private ToolStripMenuItem userFormToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem productEntryToolStripMenuItem;
        private ToolStripMenuItem productEntryToolStripMenuItem1;
        private ToolStripMenuItem productReportToolStripMenuItem1;
        private ToolStripMenuItem customerReportToolStripMenuItem;
        private ToolStripMenuItem customerReportToolStripMenuItem1;
        private ToolStripMenuItem employeeReportToolStripMenuItem;
    }
}