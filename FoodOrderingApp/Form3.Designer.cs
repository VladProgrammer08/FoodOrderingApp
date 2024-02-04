namespace FoodOrderingApp
{
    partial class Form3
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
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            txtTax = new TextBox();
            txtSubtotal = new TextBox();
            txtOrderTotal = new TextBox();
            btnAddOrder = new Button();
            btnCancel = new Button();
            groupBox4 = new GroupBox();
            cboxSoda = new CheckBox();
            cboxCoffee = new CheckBox();
            cboxTea = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cboxHumburger = new CheckBox();
            cboxPizza = new CheckBox();
            cboxHotDog = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboxHotDog);
            groupBox1.Controls.Add(cboxPizza);
            groupBox1.Controls.Add(cboxHumburger);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(53, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(239, 153);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fast foods";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(282, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(276, 142);
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
            groupBox3.Location = new Point(53, 273);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(276, 153);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Order total";
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
            // txtOrderTotal
            // 
            txtOrderTotal.Enabled = false;
            txtOrderTotal.Location = new Point(134, 118);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.Size = new Size(125, 27);
            txtOrderTotal.TabIndex = 5;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(388, 280);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(207, 61);
            btnAddOrder.TabIndex = 6;
            btnAddOrder.Text = "Add Order";
            btnAddOrder.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(388, 365);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(207, 61);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cboxTea);
            groupBox4.Controls.Add(cboxCoffee);
            groupBox4.Controls.Add(cboxSoda);
            groupBox4.Location = new Point(388, 50);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(207, 153);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Drinks";
            // 
            // cboxSoda
            // 
            cboxSoda.AutoSize = true;
            cboxSoda.Location = new Point(32, 38);
            cboxSoda.Name = "cboxSoda";
            cboxSoda.Size = new Size(65, 24);
            cboxSoda.TabIndex = 0;
            cboxSoda.Text = "Soda";
            cboxSoda.UseVisualStyleBackColor = true;
            // 
            // cboxCoffee
            // 
            cboxCoffee.AutoSize = true;
            cboxCoffee.Location = new Point(32, 80);
            cboxCoffee.Name = "cboxCoffee";
            cboxCoffee.Size = new Size(75, 24);
            cboxCoffee.TabIndex = 1;
            cboxCoffee.Text = "Сoffee";
            cboxCoffee.UseVisualStyleBackColor = true;
            // 
            // cboxTea
            // 
            cboxTea.AutoSize = true;
            cboxTea.Location = new Point(32, 120);
            cboxTea.Name = "cboxTea";
            cboxTea.Size = new Size(54, 24);
            cboxTea.TabIndex = 2;
            cboxTea.Text = "Tea";
            cboxTea.UseVisualStyleBackColor = true;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 80);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 7;
            label2.Text = "Tax(0.10%):";
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
            // cboxHumburger
            // 
            cboxHumburger.AutoSize = true;
            cboxHumburger.Location = new Point(29, 38);
            cboxHumburger.Name = "cboxHumburger";
            cboxHumburger.Size = new Size(107, 24);
            cboxHumburger.TabIndex = 2;
            cboxHumburger.Text = "Humburger";
            cboxHumburger.UseVisualStyleBackColor = true;
            // 
            // cboxPizza
            // 
            cboxPizza.AutoSize = true;
            cboxPizza.Location = new Point(29, 80);
            cboxPizza.Name = "cboxPizza";
            cboxPizza.Size = new Size(65, 24);
            cboxPizza.TabIndex = 3;
            cboxPizza.Text = "Pizza";
            cboxPizza.UseVisualStyleBackColor = true;
            // 
            // cboxHotDog
            // 
            cboxHotDog.AutoSize = true;
            cboxHotDog.Location = new Point(29, 120);
            cboxHotDog.Name = "cboxHotDog";
            cboxHotDog.Size = new Size(89, 24);
            cboxHotDog.TabIndex = 4;
            cboxHotDog.Text = "Hot Dog";
            cboxHotDog.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 485);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(btnCancel);
            Controls.Add(btnAddOrder);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Order Menu";
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
        private Button btnCancel;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox4;
        private CheckBox cboxTea;
        private CheckBox cboxCoffee;
        private CheckBox cboxSoda;
        private CheckBox cboxHotDog;
        private CheckBox cboxPizza;
        private CheckBox cboxHumburger;
    }
}