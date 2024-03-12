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
        private OrderMenu _order;

        public OrderMenuForm()
        {
            InitializeComponent();
            Text = "Add Order";
        }

        public OrderMenuForm(OrderMenu order)
        {
            InitializeComponent();
            btnAddOrder.Text = "Update Order";
            Text = "Update Order";
            _order = order;
            LoadOrderDetails();
        }

        private void LoadOrderDetails()
        {
            // Check if _order is not null and then load the details
            if (_order != null)
            {
                cboxHamburger.Checked = _order.Hamburger;
                cboxPizza.Checked = _order.Pizza;
                cboxHotDog.Checked = _order.HotDog;
                cboxSoda.Checked = _order.Soda;
                cboxCoffee.Checked = _order.Coffee;
                cboxTea.Checked = _order.Tea;
                txtName.Text = _order.Name;
                txtPhoneNumber.Text = _order.PhoneNumber;
                // Update the text boxes with the order's values
                txtSubtotal.Text = _order.Subtotal.ToString("c");
                txtTax.Text = _order.Tax.ToString("c");
                txtOrderTotal.Text = _order.OrderTotal.ToString("c");
            }
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



        // Method to retrieve the updated order details
        public OrderMenu GetUpdatedOrder()
        {
            // Create a new OrderMenu instance with updated details
            OrderMenu updatedOrder = new OrderMenu
            {
                Hamburger = cboxHamburger.Checked,
                Pizza = cboxPizza.Checked,
                HotDog = cboxHotDog.Checked,
                Soda = cboxSoda.Checked,
                Coffee = cboxCoffee.Checked,
                Tea = cboxTea.Checked,
                Subtotal = ParseCurrencyValue(txtSubtotal.Text),
                Tax = ParseCurrencyValue(txtTax.Text),
                OrderTotal = ParseCurrencyValue(txtOrderTotal.Text),
                Name = txtName.Text,
                PhoneNumber = txtPhoneNumber.Text
            };

            return updatedOrder;
        }



        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || txtPhoneNumber.Text == string.Empty)
            {
                MessageBox.Show("You need to fill in the Name and Phone Number fields", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Check if at least one item is selected
                    if (!cboxHamburger.Checked && !cboxPizza.Checked && !cboxHotDog.Checked &&
                        !cboxSoda.Checked && !cboxCoffee.Checked && !cboxTea.Checked)
                    {
                        MessageBox.Show("You need to choose at least one item.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method to prevent adding an empty order
                    }

                    // Parse numeric values (subtotal, tax, orderTotal)
                    double subtotal = ParseCurrencyValue(txtSubtotal.Text);
                    double tax = ParseCurrencyValue(txtTax.Text);
                    double orderTotal = ParseCurrencyValue(txtOrderTotal.Text);

                    // Get customer details
                    string name = txtName.Text;
                    string phoneNumber = txtPhoneNumber.Text;

                    // Create a new OrderMenu instance
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
                        OrderTotal = orderTotal,
                        Name = name,
                        PhoneNumber = phoneNumber,
                    };

                    // Save the order to the database
                    using (var context = new FoodOrderingContext())
                    {
                        context.OrderMenus.Add(order);
                        context.SaveChanges();
                    }

                    MessageBox.Show("Order added successfully!");
                    this.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid input. Please check the numeric values.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private double ParseCurrencyValue(string input)
        {
            input = input.Replace("$", "").Trim(); // Remove dollar sign and any extra spaces
            return double.Parse(input);

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

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (name.Any(char.IsDigit))
            {

                lblNameValidation.Text = "Name must be valid.";
            }
            else
            {
                lblNameValidation.Text = null;
                lblNameValidation.Visible = false;
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string phoneNumber = txtPhoneNumber.Text.Trim();

            if (phoneNumber.Any(char.IsLetter))
            {

                lblPhoneValidation.Text = "Phone number must be valid";
            }
            else
            {
                lblPhoneValidation.Text = null;
                lblPhoneValidation.Visible = false;
            }
        }
    }
}
