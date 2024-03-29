﻿using FoodOrderingApp.DB_Data;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FoodOrderingApp
{
    public partial class OrderListForm : Form
    {
        public OrderListForm()
        {
            InitializeComponent();
            PlaceOrderList();
        }

        private void lstboxWaitList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Displays all the Customer names with its orders in the list box
        /// </summary>
        public void PlaceOrderList()
        {
            using (var context = new FoodOrderingContext())
            {
                lstboxWaitList.Items.Clear();

                var orders = context.OrderMenus.ToList();

                foreach (var order in orders)
                {
                    if (order != null)
                    {
                        string name = $"{order.Name}";
                        // Add the full name to the ListBox
                        lstboxWaitList.Items.Add($"{order.OrderId} - {name} - Order Price:{order.OrderTotal}");
                    }
                }
            }
        }

        /// <summary>
        /// Updates a selected Customer name with its order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (lstboxWaitList.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose an order to update.");
                return;
            }

            // Get the selected order details
            string selectedOrderDetails = lstboxWaitList.SelectedItem.ToString();
            int orderId = int.Parse(selectedOrderDetails.Split('-')[0].Trim());

            // Find the order in the database
            using (var context = new FoodOrderingContext())
            {
                var orderToUpdate = context.OrderMenus.FirstOrDefault(o => o.OrderId == orderId);
                if (orderToUpdate != null)
                {
                    // Open the order form and pass the order to it for updating
                    OrderMenuForm orderForm = new OrderMenuForm(orderToUpdate);
                    orderForm.ShowDialog();

                    // Retrieve the updated order details
                    OrderMenu updatedOrder = orderForm.GetUpdatedOrder();

                    // Update the order details in the database with the updated order
                    orderToUpdate.Hamburger = updatedOrder.Hamburger;
                    orderToUpdate.Pizza = updatedOrder.Pizza;
                    orderToUpdate.HotDog = updatedOrder.HotDog;
                    orderToUpdate.Soda = updatedOrder.Soda;
                    orderToUpdate.Coffee = updatedOrder.Coffee;
                    orderToUpdate.Tea = updatedOrder.Tea;
                    orderToUpdate.Subtotal = updatedOrder.Subtotal;
                    orderToUpdate.Tax = updatedOrder.Tax;
                    orderToUpdate.OrderTotal = updatedOrder.OrderTotal;
                    orderToUpdate.Name = updatedOrder.Name;
                    orderToUpdate.PhoneNumber = updatedOrder.PhoneNumber;

                    // Save changes to the database
                    context.SaveChanges();

                    // Delete the original order from the database
                    context.OrderMenus.Remove(context.OrderMenus.FirstOrDefault(o => o.OrderId == orderId));
                    context.SaveChanges();

                    // Refresh the wait list with the updated order details
                    PlaceOrderList();
                }
            }
        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Deletes a selected Customer name with its order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            string selectedItem = lstboxWaitList.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedItem))
            {
                // Extract the Order ID from the selected item
                int orderId = int.Parse(selectedItem.Split('-')[0].Trim());

                // Delete the order with the specified Order ID
                using (var context = new FoodOrderingContext())
                {
                    var orderToDelete = context.OrderMenus.FirstOrDefault(o => o.OrderId == orderId);
                    if (orderToDelete != null)
                    {
                        context.OrderMenus.Remove(orderToDelete);
                        context.SaveChanges();
                        MessageBox.Show("Order deleted successfully!");
                        // Refresh the list box after deletion
                        PlaceOrderList();
                    }
                    else
                    {
                        MessageBox.Show("Order not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an order to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    
}
