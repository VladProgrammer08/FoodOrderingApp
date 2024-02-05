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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Form2 addCustomer = new Form2();
            addCustomer.ShowDialog();


        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            Form3 addOrder = new Form3();
            addOrder.ShowDialog();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            Form4 placeOrder = new Form4();
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
