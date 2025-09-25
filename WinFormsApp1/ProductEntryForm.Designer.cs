namespace WinFormsApp1
{
    partial class ProductEntryForm
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
            label14 = new Label();
            textBox10 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(209, 348);
            label14.Name = "label14";
            label14.Size = new Size(152, 37);
            label14.TabIndex = 37;
            label14.Text = "Description";
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox10.Location = new Point(209, 158);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(287, 43);
            textBox10.TabIndex = 35;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(554, 232);
            label13.Name = "label13";
            label13.Size = new Size(119, 37);
            label13.TabIndex = 34;
            label13.Text = "Quantity";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(209, 118);
            label12.Name = "label12";
            label12.Size = new Size(139, 37);
            label12.TabIndex = 33;
            label12.Text = "Product Id";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(209, 232);
            label11.Name = "label11";
            label11.Size = new Size(74, 37);
            label11.TabIndex = 32;
            label11.Text = "Price";
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox9.Location = new Point(209, 272);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(287, 43);
            textBox9.TabIndex = 31;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox8.Location = new Point(554, 158);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(287, 43);
            textBox8.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(554, 118);
            label10.Name = "label10";
            label10.Size = new Size(194, 37);
            label10.TabIndex = 29;
            label10.Text = "Product Name ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkOliveGreen;
            label9.Location = new Point(209, 59);
            label9.Name = "label9";
            label9.Size = new Size(332, 37);
            label9.TabIndex = 28;
            label9.Text = "PRODUCT INFORMATION";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "10", "20", "30", "40", "50" });
            comboBox1.Location = new Point(554, 272);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(287, 45);
            comboBox1.TabIndex = 39;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(209, 397);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(632, 43);
            textBox1.TabIndex = 40;
            // 
            // button1
            // 
            // button1
            button1.BackColor = Color.Beige;
            button1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(328, 475);
            button1.Name = "button1";
            button1.Size = new Size(434, 52);
            button1.TabIndex = 46;
            button1.Text = "Save Product Details";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new EventHandler(this.btnSave_Click);  // ✅ Event wired here

            // 
            // ProductEntryFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 556);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label14);
            Controls.Add(textBox10);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(label10);
            Controls.Add(label9);
            Name = "ProductEntryFrom";
            Text = "ProductEntryFrom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label14;
        private TextBox textBox10;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox textBox9;
        private TextBox textBox8;
        private Label label10;
        private Label label9;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button1;
    }
}