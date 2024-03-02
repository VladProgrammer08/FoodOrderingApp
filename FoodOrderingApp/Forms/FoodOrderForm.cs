using FoodOrderingApp.DB_Data;
using FoodOrderingApp.Models;
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

        public void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomer = new AddCustomerForm();
            addCustomer.ShowDialog();
            CustomerListBox();


        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            OrderMenuForm addOrder = new OrderMenuForm();
            addOrder.ShowDialog();
            OrderListBox();
        }

        public void btnPlaceOrder_Click(object sender, EventArgs e)
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
        public void Form1_Load(object sender, EventArgs e)
        {
        }

        public void lstCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void CustomerListBox()
        {
            lstCustomer.Items.Clear();

            using (var context = new FoodOrderingContext())
            {
                // Retrieve the last added customer
                var lastAddedCustomer = context.AddCustomers
                    .OrderByDescending(c => c.CustomerId)
                    .FirstOrDefault();

                if (lastAddedCustomer != null)
                {
                    // Combine first and last names
                    string fullName = $"{lastAddedCustomer.FirstName} {lastAddedCustomer.LastName}";
                    // Add the full name to the ListBox
                    lstCustomer.Items.Add(fullName);
                }
            }
        }

        public void OrderListBox()
        {
            lstOrder.Items.Clear();

            using (var context = new FoodOrderingContext())
            {
                var lastAddedOrder = context.orderMenus
                    .OrderByDescending(c => c.OrderId)
                    .FirstOrDefault();

                if (lastAddedOrder != null)
                {
                    if (lastAddedOrder.Hamburger) lstOrder.Items.Add("Hamburger");
                    if (lastAddedOrder.Pizza) lstOrder.Items.Add("Pizza");
                    if (lastAddedOrder.HotDog) lstOrder.Items.Add("Hot Dog");
                    if (lastAddedOrder.Soda) lstOrder.Items.Add("Soda");
                    if (lastAddedOrder.Coffee) lstOrder.Items.Add("Coffee");
                    if (lastAddedOrder.Tea) lstOrder.Items.Add("Tea");
                }
            }
            
        }
        
    }
}
