﻿namespace FoodOrderingApp
{
    partial class FoodOrderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstOrder = new ListBox();
            lstCustomer = new ListBox();
            btnAddOrder = new Button();
            btnPlaceOrder = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(235, 58);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(183, 224);
            lstOrder.TabIndex = 0;
            // 
            // lstCustomer
            // 
            lstCustomer.FormattingEnabled = true;
            lstCustomer.Location = new Point(35, 58);
            lstCustomer.Name = "lstCustomer";
            lstCustomer.Size = new Size(183, 224);
            lstCustomer.TabIndex = 1;
            lstCustomer.SelectedIndexChanged += lstCustomer_SelectedIndexChanged;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(487, 58);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(173, 147);
            btnAddOrder.TabIndex = 3;
            btnAddOrder.Text = "Add Order";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(35, 342);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(383, 77);
            btnPlaceOrder.TabIndex = 4;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(487, 272);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(173, 147);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // FoodOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 450);
            Controls.Add(btnExit);
            Controls.Add(btnPlaceOrder);
            Controls.Add(btnAddOrder);
            Controls.Add(lstCustomer);
            Controls.Add(lstOrder);
            Name = "FoodOrderForm";
            Text = "Food Order Form";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstOrder;
        private ListBox lstCustomer;
        private Button btnAddOrder;
        private Button btnPlaceOrder;
        private Button btnExit;
    }
}
