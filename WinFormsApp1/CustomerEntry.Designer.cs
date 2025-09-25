namespace WinFormsApp1
{
    partial class CustomerEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerEntry));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 87);
            label3.Name = "label3";
            label3.Size = new Size(984, 30);
            label3.TabIndex = 5;
            label3.Text = "Please fill out the customer information form below to join . Feilds marked with a red star are mandatory ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 37);
            label2.Name = "label2";
            label2.Size = new Size(0, 30);
            label2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(60, 9);
            label1.Name = "label1";
            label1.Size = new Size(641, 65);
            label1.TabIndex = 3;
            label1.Text = "Customer Information Form";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(62, 167);
            label4.Name = "label4";
            label4.Size = new Size(169, 30);
            label4.TabIndex = 6;
            label4.Text = "Customer Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1107, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(843, 210);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Last";
            textBox2.Size = new Size(224, 39);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(586, 212);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Initials";
            textBox3.Size = new Size(224, 39);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(333, 212);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "First";
            textBox4.Size = new Size(224, 39);
            textBox4.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "Mr.", "Ms.", "Dr.", "Mrs.", "Mr." });
            comboBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mr.", "Ms.", "Dr.", "Mrs.", "Mr." });
            comboBox1.Location = new Point(62, 212);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(224, 38);
            comboBox1.TabIndex = 40;
            comboBox1.Text = "Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(63, 265);
            label5.Name = "label5";
            label5.Size = new Size(189, 30);
            label5.TabIndex = 41;
            label5.Text = "Customer Address";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(63, 312);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Street Address";
            textBox1.Size = new Size(1004, 39);
            textBox1.TabIndex = 42;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(63, 371);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Street Address Line2";
            textBox5.Size = new Size(1004, 39);
            textBox5.TabIndex = 43;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(586, 435);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "City ";
            textBox6.Size = new Size(481, 39);
            textBox6.TabIndex = 44;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(63, 435);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Region";
            textBox7.Size = new Size(494, 39);
            textBox7.TabIndex = 45;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox8.Location = new Point(63, 490);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "Postal / Zip Code";
            textBox8.Size = new Size(494, 39);
            textBox8.TabIndex = 46;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox9.Location = new Point(63, 589);
            textBox9.Name = "textBox9";
            textBox9.PasswordChar = '#';
            textBox9.Size = new Size(494, 39);
            textBox9.TabIndex = 47;
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox10.Location = new Point(586, 589);
            textBox10.Name = "textBox10";
            textBox10.PasswordChar = '#';
            textBox10.Size = new Size(481, 39);
            textBox10.TabIndex = 48;
            // 
            // textBox11
            // 
            textBox11.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox11.Location = new Point(586, 680);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(481, 39);
            textBox11.TabIndex = 49;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Afghanistan", "Albania", "Algeria", "Argentina", "Australia", "Austria", "Bangladesh", "Belgium", "Brazil", "Canada", "China", "Denmark", "Egypt", "Finland", "France", "Germany", "Greece", "India", "Indonesia", "Ireland", "Italy", "Japan", "Kenya", "Malaysia", "Mexico", "Nepal", "Netherlands", "New Zealand", "Nigeria", "Norway", "Pakistan", "Philippines", "Poland", "Portugal", "Qatar", "Russia", "Saudi Arabia", "Singapore", "South Africa", "South Korea", "Spain", "Sri Lanka", "Sweden", "Switzerland", "Thailand", "Turkey", "United Arab Emirates", "United Kingdom", "United States", "Vietnam", "Zimbabwe" });
            comboBox2.Location = new Point(586, 490);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(481, 38);
            comboBox2.TabIndex = 50;
            comboBox2.Text = "Country";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(63, 680);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(494, 39);
            dateTimePicker1.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(63, 556);
            label6.Name = "label6";
            label6.Size = new Size(172, 30);
            label6.TabIndex = 52;
            label6.Text = "Customer Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(586, 556);
            label7.Name = "label7";
            label7.Size = new Size(144, 30);
            label7.TabIndex = 53;
            label7.Text = "Customer Fax";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(60, 647);
            label8.Name = "label8";
            label8.Size = new Size(236, 30);
            label8.TabIndex = 54;
            label8.Text = "Customer Date of Birth";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(586, 647);
            label9.Name = "label9";
            label9.Size = new Size(193, 30);
            label9.TabIndex = 55;
            label9.Text = "Customer ID/Email";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(63, 805);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(494, 29);
            checkBox1.TabIndex = 57;
            checkBox1.Text = "I allow my information to be used for future campaigns";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(423, 859);
            button1.Name = "button1";
            button1.Size = new Size(298, 52);
            button1.TabIndex = 58;
            button1.Text = "Send Information";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnSendInformation_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(60, 744);
            label11.Name = "label11";
            label11.Size = new Size(911, 90);
            label11.TabIndex = 56;
            label11.Text = "All customer information will be kept with descretion and will not be used for other marketing or \r\nadvertisment purposes without customer approval.\r\n\r\n";
            // 
            // CustomerEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 931);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "CustomerEntry";
            Text = "CustomerEntry";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private CheckBox checkBox1;
        private Button button1;
        private Label label11;
    }
}