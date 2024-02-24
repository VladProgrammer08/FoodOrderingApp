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
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboxHotDog);
            groupBox1.Controls.Add(cboxPizza);
            groupBox1.Controls.Add(cboxHamburger);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(46, 38);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(209, 115);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fast foods";
            // 
            // cboxHotDog
            // 
            cboxHotDog.AutoSize = true;
            cboxHotDog.Location = new Point(25, 90);
            cboxHotDog.Margin = new Padding(3, 2, 3, 2);
            cboxHotDog.Name = "cboxHotDog";
            cboxHotDog.Size = new Size(109, 19);
            cboxHotDog.TabIndex = 4;
            cboxHotDog.Text = "Hot Dog - $3.99";
            cboxHotDog.UseVisualStyleBackColor = true;
            cboxHotDog.CheckedChanged += cboxHotDog_CheckedChanged;
            // 
            // cboxPizza
            // 
            cboxPizza.AutoSize = true;
            cboxPizza.Location = new Point(25, 60);
            cboxPizza.Margin = new Padding(3, 2, 3, 2);
            cboxPizza.Name = "cboxPizza";
            cboxPizza.Size = new Size(90, 19);
            cboxPizza.TabIndex = 3;
            cboxPizza.Text = "Pizza - $4.99";
            cboxPizza.UseVisualStyleBackColor = true;
            cboxPizza.CheckedChanged += cboxPizza_CheckedChanged;
            // 
            // cboxHamburger
            // 
            cboxHamburger.AutoSize = true;
            cboxHamburger.Location = new Point(25, 28);
            cboxHamburger.Margin = new Padding(3, 2, 3, 2);
            cboxHamburger.Name = "cboxHamburger";
            cboxHamburger.Size = new Size(125, 19);
            cboxHamburger.TabIndex = 2;
            cboxHamburger.Text = "Hamburger - $5.99";
            cboxHamburger.UseVisualStyleBackColor = true;
            cboxHamburger.CheckedChanged += cboxHamburger_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(247, 2);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(242, 106);
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
            groupBox3.Location = new Point(46, 205);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(242, 115);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Order total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 91);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 8;
            label3.Text = "Order total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 60);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 7;
            label2.Text = "Tax(0.10%):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 33);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 6;
            label1.Text = "Subtotal:";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Enabled = false;
            txtOrderTotal.Location = new Point(117, 88);
            txtOrderTotal.Margin = new Padding(3, 2, 3, 2);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.Size = new Size(110, 23);
            txtOrderTotal.TabIndex = 5;
            // 
            // txtTax
            // 
            txtTax.Enabled = false;
            txtTax.Location = new Point(117, 58);
            txtTax.Margin = new Padding(3, 2, 3, 2);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(110, 23);
            txtTax.TabIndex = 3;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Enabled = false;
            txtSubtotal.Location = new Point(117, 31);
            txtSubtotal.Margin = new Padding(3, 2, 3, 2);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(110, 23);
            txtSubtotal.TabIndex = 4;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(340, 210);
            btnAddOrder.Margin = new Padding(3, 2, 3, 2);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(181, 46);
            btnAddOrder.TabIndex = 6;
            btnAddOrder.Text = "Add Order";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // btnBack3
            // 
            btnBack3.Location = new Point(340, 274);
            btnBack3.Margin = new Padding(3, 2, 3, 2);
            btnBack3.Name = "btnBack3";
            btnBack3.Size = new Size(181, 46);
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
            groupBox4.Location = new Point(340, 38);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(181, 115);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Drinks";
            // 
            // cboxTea
            // 
            cboxTea.AutoSize = true;
            cboxTea.Location = new Point(28, 90);
            cboxTea.Margin = new Padding(3, 2, 3, 2);
            cboxTea.Name = "cboxTea";
            cboxTea.Size = new Size(81, 19);
            cboxTea.TabIndex = 2;
            cboxTea.Text = "Tea - $1.99";
            cboxTea.UseVisualStyleBackColor = true;
            cboxTea.CheckedChanged += cboxTea_CheckedChanged;
            // 
            // cboxCoffee
            // 
            cboxCoffee.AutoSize = true;
            cboxCoffee.Location = new Point(28, 60);
            cboxCoffee.Margin = new Padding(3, 2, 3, 2);
            cboxCoffee.Name = "cboxCoffee";
            cboxCoffee.Size = new Size(99, 19);
            cboxCoffee.TabIndex = 1;
            cboxCoffee.Text = "Сoffee - $1.99";
            cboxCoffee.UseVisualStyleBackColor = true;
            cboxCoffee.CheckedChanged += cboxCoffee_CheckedChanged;
            // 
            // cboxSoda
            // 
            cboxSoda.AutoSize = true;
            cboxSoda.Location = new Point(28, 28);
            cboxSoda.Margin = new Padding(3, 2, 3, 2);
            cboxSoda.Name = "cboxSoda";
            cboxSoda.Size = new Size(90, 19);
            cboxSoda.TabIndex = 0;
            cboxSoda.Text = "Soda - $2.99";
            cboxSoda.UseVisualStyleBackColor = true;
            cboxSoda.CheckedChanged += cboxSoda_CheckedChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 364);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(btnBack3);
            Controls.Add(btnAddOrder);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            Text = "Order Menu";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
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
    }
}