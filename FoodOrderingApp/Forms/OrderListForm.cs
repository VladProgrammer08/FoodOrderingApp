using FoodOrderingApp.DB_Data;
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
    }
}
