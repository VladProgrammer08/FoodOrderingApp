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
                var customers = context.AddCustomers.ToList();
                var orders = context.orderMenus.ToList();

                foreach (var order in orders)
                {
                    var customer = customers.FirstOrDefault(c => c.CustomerId == order.OrderId);
                    if (customer != null)
                    {
                        string fullName = $"{customer.FirstName} {customer.LastName}";
                        // Add the full name to the ListBox
                        lstboxWaitList.Items.Add($"{fullName} - Order Price:{order.OrderTotal}");
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
            //UpdateOrder();
            
            
        }


        //public void UpdateOrder()
        //{
            //var selectedIndex = lstboxWaitList.SelectedIndex;
            //if (selectedIndex != -1)
            //{

                //using (var context = new FoodOrderingContext())
                //{
                    
                    //{

                        //var updateForm = new OrderMenuForm(selectedIndex);
                        //updateForm.ShowDialog();


                        //PlaceOrderList();
                    //}
                    //else
                    //{
                        //MessageBox.Show("Order not found.");
                    //}
               // }
            //}
            //else
            //{
               // MessageBox.Show("Please choose an order to update.");
           // }
       // }
    }
}
