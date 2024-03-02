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
    public partial class OrderMenuForm : Form
    {
        public OrderMenuForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }



        const double HAMBURGER_PRICE = 5.99;
        const double PIZZA_PRICE = 4.99;
        const double HOTDOG_PRICE = 3.99;

        const double SODA_PRICE = 2.99;
        const double COFFEE_PRICE = 1.99;
        const double TEA_PRICE = 1.99;

        double taxRate = 0.10;

        private void CalculateOrderTotal()
        {
            double subtotal = 0;

            if (cboxHamburger.Checked)
            {
                subtotal += HAMBURGER_PRICE;
            }
            if (cboxPizza.Checked)
            {
                subtotal += PIZZA_PRICE;
            }
            if (cboxHotDog.Checked)
            {
                subtotal += HOTDOG_PRICE;
            }
            if (cboxSoda.Checked)
            {
                subtotal += SODA_PRICE;
            }
            if (cboxCoffee.Checked)
            {
                subtotal += COFFEE_PRICE;
            }
            if (cboxTea.Checked)
            {
                subtotal += TEA_PRICE;
            }

            double taxAmount = subtotal * taxRate;
            double orderTotal = subtotal + taxAmount;

            txtSubtotal.Text = subtotal.ToString("c");
            txtTax.Text = taxAmount.ToString("c");
            txtOrderTotal.Text = orderTotal.ToString("c");
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            string value = txtSubtotal.Text;
            value = value.Replace("$", "");
            double subtotal = double.Parse(value);

            string value2 = txtTax.Text;
            value2 = value2.Replace("$", "");
            double tax = double.Parse(value2);

            string value3 = txtOrderTotal.Text;
            value3 = value3.Replace("$", "");
            double orderTotal = double.Parse(value3);

            var order = new OrderMenu
            {
                Hamburger = cboxHamburger.Checked,
                Pizza = cboxPizza.Checked,
                HotDog = cboxHotDog.Checked,
                Soda = cboxSoda.Checked,
                Coffee = cboxCoffee.Checked,
                Tea = cboxTea.Checked,
                Subtotal = subtotal,
                Tax = tax,
                OrderTotal = orderTotal
            };
            FoodOrderingContext context = new();
            context.orderMenus.Add(order);
            context.SaveChanges();
            MessageBox.Show("Order added successfully!");
            this.Close();
        }

        private void cboxHamburger_CheckedChanged(object sender, EventArgs e)
        {
            CalculateOrderTotal();
        }

        private void cboxPizza_CheckedChanged(object sender, EventArgs e)
        {
            CalculateOrderTotal();
        }

        private void cboxHotDog_CheckedChanged(object sender, EventArgs e)
        {
            CalculateOrderTotal();
        }

        private void cboxSoda_CheckedChanged(object sender, EventArgs e)
        {
            CalculateOrderTotal();
        }

        private void cboxCoffee_CheckedChanged(object sender, EventArgs e)
        {
            CalculateOrderTotal();
        }

        private void cboxTea_CheckedChanged(object sender, EventArgs e)
        {
            CalculateOrderTotal();
        }

        private void btnBack3_Click(object sender, EventArgs e)
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
    }
}
