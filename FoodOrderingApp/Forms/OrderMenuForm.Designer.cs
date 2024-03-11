namespace FoodOrderingApp
{
    partial class OrderMenuForm
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
            groupBox1 = new GroupBox();
            cboxHotDog = new CheckBox();
            cboxPizza = new CheckBox();
            cboxHamburger = new CheckBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtOrderTotal = new TextBox();
            txtTax = new TextBox();
            txtSubtotal = new TextBox();
            btnAddOrder = new Button();
            btnBack3 = new Button();
            groupBox4 = new GroupBox();
            cboxTea = new CheckBox();
            cboxCoffee = new CheckBox();
            cboxSoda = new CheckBox();
            groupBox5 = new GroupBox();
            lblPhoneValidation = new Label();
            lblNameValidatin = new Label();
            txtPhoneNumber = new TextBox();
            txtName = new TextBox();
            lblPhoneNumber = new Label();
            lblName = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboxHotDog);
            groupBox1.Controls.Add(cboxPizza);
            groupBox1.Controls.Add(cboxHamburger);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(53, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(239, 153);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fast foods";
            // 
            // cboxHotDog
            // 
            cboxHotDog.AutoSize = true;
            cboxHotDog.Location = new Point(29, 120);
            cboxHotDog.Name = "cboxHotDog";
            cboxHotDog.Size = new Size(138, 24);
            cboxHotDog.TabIndex = 4;
            cboxHotDog.Text = "Hot Dog - $3.99";
            cboxHotDog.UseVisualStyleBackColor = true;
            cboxHotDog.CheckedChanged += cboxHotDog_CheckedChanged;
            // 
            // cboxPizza
            // 
            cboxPizza.AutoSize = true;
            cboxPizza.Location = new Point(29, 80);
            cboxPizza.Name = "cboxPizza";
            cboxPizza.Size = new Size(114, 24);
            cboxPizza.TabIndex = 3;
            cboxPizza.Text = "Pizza - $4.99";
            cboxPizza.UseVisualStyleBackColor = true;
            cboxPizza.CheckedChanged += cboxPizza_CheckedChanged;
            // 
            // cboxHamburger
            // 
            cboxHamburger.AutoSize = true;
            cboxHamburger.Location = new Point(29, 37);
            cboxHamburger.Name = "cboxHamburger";
            cboxHamburger.Size = new Size(156, 24);
            cboxHamburger.TabIndex = 2;
            cboxHamburger.Text = "Hamburger - $5.99";
            cboxHamburger.UseVisualStyleBackColor = true;
            cboxHamburger.CheckedChanged += cboxHamburger_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(282, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(277, 141);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txtOrderTotal);
            groupBox3.Controls.Add(txtTax);
            groupBox3.Controls.Add(txtSubtotal);
            groupBox3.Location = new Point(53, 487);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(277, 153);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Order total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 121);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 8;
            label3.Text = "Order total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 80);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 7;
            label2.Text = "Tax(0.10%):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 44);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 6;
            label1.Text = "Subtotal:";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Enabled = false;
            txtOrderTotal.Location = new Point(134, 117);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.Size = new Size(125, 27);
            txtOrderTotal.TabIndex = 5;
            // 
            // txtTax
            // 
            txtTax.Enabled = false;
            txtTax.Location = new Point(134, 77);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(125, 27);
            txtTax.TabIndex = 3;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Enabled = false;
            txtSubtotal.Location = new Point(134, 41);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(125, 27);
            txtSubtotal.TabIndex = 4;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(405, 497);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(207, 61);
            btnAddOrder.TabIndex = 6;
            btnAddOrder.Text = "Add Order";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // btnBack3
            // 
            btnBack3.Location = new Point(405, 579);
            btnBack3.Name = "btnBack3";
            btnBack3.Size = new Size(207, 61);
            btnBack3.TabIndex = 7;
            btnBack3.Text = "Back";
            btnBack3.UseVisualStyleBackColor = true;
            btnBack3.Click += btnBack3_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cboxTea);
            groupBox4.Controls.Add(cboxCoffee);
            groupBox4.Controls.Add(cboxSoda);
            groupBox4.Location = new Point(53, 245);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(239, 153);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Drinks";
            // 
            // cboxTea
            // 
            cboxTea.AutoSize = true;
            cboxTea.Location = new Point(32, 120);
            cboxTea.Name = "cboxTea";
            cboxTea.Size = new Size(103, 24);
            cboxTea.TabIndex = 2;
            cboxTea.Text = "Tea - $1.99";
            cboxTea.UseVisualStyleBackColor = true;
            cboxTea.CheckedChanged += cboxTea_CheckedChanged;
            // 
            // cboxCoffee
            // 
            cboxCoffee.AutoSize = true;
            cboxCoffee.Location = new Point(32, 80);
            cboxCoffee.Name = "cboxCoffee";
            cboxCoffee.Size = new Size(124, 24);
            cboxCoffee.TabIndex = 1;
            cboxCoffee.Text = "Сoffee - $1.99";
            cboxCoffee.UseVisualStyleBackColor = true;
            cboxCoffee.CheckedChanged += cboxCoffee_CheckedChanged;
            // 
            // cboxSoda
            // 
            cboxSoda.AutoSize = true;
            cboxSoda.Location = new Point(32, 37);
            cboxSoda.Name = "cboxSoda";
            cboxSoda.Size = new Size(114, 24);
            cboxSoda.TabIndex = 0;
            cboxSoda.Text = "Soda - $2.99";
            cboxSoda.UseVisualStyleBackColor = true;
            cboxSoda.CheckedChanged += cboxSoda_CheckedChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblPhoneValidation);
            groupBox5.Controls.Add(lblNameValidatin);
            groupBox5.Controls.Add(txtPhoneNumber);
            groupBox5.Controls.Add(txtName);
            groupBox5.Controls.Add(lblPhoneNumber);
            groupBox5.Controls.Add(lblName);
            groupBox5.Location = new Point(367, 51);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(272, 348);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Customer";
            // 
            // lblPhoneValidation
            // 
            lblPhoneValidation.AutoSize = true;
            lblPhoneValidation.ForeColor = Color.Red;
            lblPhoneValidation.Location = new Point(55, 278);
            lblPhoneValidation.Name = "lblPhoneValidation";
            lblPhoneValidation.Size = new Size(15, 20);
            lblPhoneValidation.TabIndex = 5;
            lblPhoneValidation.Text = "*";
            // 
            // lblNameValidatin
            // 
            lblNameValidatin.AutoSize = true;
            lblNameValidatin.ForeColor = Color.Red;
            lblNameValidatin.Location = new Point(55, 124);
            lblNameValidatin.Name = "lblNameValidatin";
            lblNameValidatin.Size = new Size(15, 20);
            lblNameValidatin.TabIndex = 4;
            lblNameValidatin.Text = "*";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(55, 232);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(173, 27);
            txtPhoneNumber.TabIndex = 3;
            txtPhoneNumber.TextChanged += txtPhoneNumber_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(55, 80);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(173, 27);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(22, 195);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(111, 20);
            lblPhoneNumber.TabIndex = 1;
            lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(22, 37);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            lblName.Click += lblName_Click;
            // 
            // OrderMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 696);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(btnBack3);
            Controls.Add(btnAddOrder);
            Controls.Add(groupBox1);
            Name = "OrderMenuForm";
            Text = "Order Menu";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txtOrderTotal;
        private TextBox txtTax;
        private TextBox txtSubtotal;
        private Button btnAddOrder;
        private Button btnBack3;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox4;
        private CheckBox cboxTea;
        private CheckBox cboxCoffee;
        private CheckBox cboxSoda;
        private CheckBox cboxHotDog;
        private CheckBox cboxPizza;
        private CheckBox cboxHamburger;
        private GroupBox groupBox5;
        private TextBox txtPhoneNumber;
        private TextBox txtName;
        private Label lblPhoneNumber;
        private Label lblName;
        private Label lblPhoneValidation;
        private Label lblNameValidatin;
    }
}