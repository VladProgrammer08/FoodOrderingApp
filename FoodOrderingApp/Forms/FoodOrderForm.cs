using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderingApp
{
    public partial class FoodOrderForm : Form
    {
        public FoodOrderForm()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomer = new AddCustomerForm();
            addCustomer.ShowDialog();


        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            OrderMenuForm addOrder = new OrderMenuForm();
            addOrder.ShowDialog();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            OrderListForm placeOrder = new OrderListForm();
            placeOrder.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult choice =
               MessageBox.Show("Are you sure you want to Exit?", "Attention",
                   MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning);
            if (choice == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
