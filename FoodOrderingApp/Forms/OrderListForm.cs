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

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (lstboxWaitList.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose an order to update.");
                return;
            }
            UpdateOrder();


        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {

        }


        public void UpdateOrder()
        {

            string selectedOrderDetails = lstboxWaitList.SelectedItem.ToString();

            // Assuming the order ID is at the beginning followed by ' - '
            int orderId = int.Parse(selectedOrderDetails.Split('-')[0].Trim());

            // Find the order in the database
            using (var context = new FoodOrderingContext())
            {
                var orderToUpdate = context.OrderMenus.FirstOrDefault(o => o.OrderId == orderId);
                if (orderToUpdate != null)
                {
                    // Open the order form and pass the order to it
                    OrderMenuForm orderForm = new OrderMenuForm(orderToUpdate);
                    orderForm.ShowDialog();
                    context.OrderMenus.Update(orderToUpdate);

                    context.SaveChanges();
                    // Refresh the list after updating
                    PlaceOrderList();
                }
            }

        }

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
