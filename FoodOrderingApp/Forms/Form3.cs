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
    public partial class Form3 : Form
    {
        public Form3()
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
    }
}
