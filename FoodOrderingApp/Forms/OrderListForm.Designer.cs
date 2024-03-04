namespace FoodOrderingApp
{
    partial class OrderListForm
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
            lstboxWaitList = new ListBox();
            btnUpdateOrder = new Button();
            btnDeleteOrder = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstboxWaitList
            // 
            lstboxWaitList.FormattingEnabled = true;
            lstboxWaitList.Location = new Point(56, 101);
            lstboxWaitList.Name = "lstboxWaitList";
            lstboxWaitList.Size = new Size(331, 224);
            lstboxWaitList.TabIndex = 0;
            lstboxWaitList.SelectedIndexChanged += lstboxWaitList_SelectedIndexChanged;
            // 
            // btnUpdateOrder
            // 
            btnUpdateOrder.Location = new Point(454, 115);
            btnUpdateOrder.Name = "btnUpdateOrder";
            btnUpdateOrder.Size = new Size(153, 60);
            btnUpdateOrder.TabIndex = 1;
            btnUpdateOrder.Text = "Update Order";
            btnUpdateOrder.UseVisualStyleBackColor = true;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Location = new Point(454, 238);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(153, 60);
            btnDeleteOrder.TabIndex = 2;
            btnDeleteOrder.Text = "Delete Order";
            btnDeleteOrder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 68);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 3;
            label1.Text = "Wait List";
            // 
            // OrderListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 372);
            Controls.Add(label1);
            Controls.Add(btnDeleteOrder);
            Controls.Add(btnUpdateOrder);
            Controls.Add(lstboxWaitList);
            Name = "OrderListForm";
            Text = "Order List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstboxWaitList;
        private Button btnUpdateOrder;
        private Button btnDeleteOrder;
        private Label label1;
    }
}