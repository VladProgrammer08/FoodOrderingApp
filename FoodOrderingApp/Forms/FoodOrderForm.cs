using FoodOrderingApp.DB_Data;
using FoodOrderingApp.Models;
using Microsoft.EntityFrameworkCore;
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

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            OrderMenuForm addOrder = new OrderMenuForm();
            addOrder.ShowDialog();
            OrderListBox();
            CustomerListBox();
        }

        public void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            ListBoxValidation();
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
                var lastAddedCustomer = context.OrderMenus
                    .OrderByDescending(c => c.OrderId)
                    .FirstOrDefault();

                if (lastAddedCustomer != null)
                {
                    // Combine first and last names
                    string name = $"{lastAddedCustomer.Name}";
                    // Add the full name to the ListBox
                    lstCustomer.Items.Add(name);
                }
            }
        }

        public void OrderListBox()
        {
            lstOrder.Items.Clear();

            using (var context = new FoodOrderingContext())
            {
                var lastAddedOrder = context.OrderMenus
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

        public void ListBoxValidation()
        {
            if (lstCustomer.Items.Count == 0 || lstOrder.Items.Count == 0)
            {
                MessageBox.Show("Both Customer and Order information must be added.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OrderListForm placeOrder = new OrderListForm();
                placeOrder.ShowDialog();
            }
        }

        
        
    }
}
