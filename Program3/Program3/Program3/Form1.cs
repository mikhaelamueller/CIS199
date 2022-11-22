//R8507
//CIS 199-01
//Program 3
//Due 4/1/2021
//Uses parallel arrays and range matching. It allows the user to input state, product number and quantity and return a price to the user
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // array that stores the tax rate for the particular state
        readonly double[] discountRates = { 0.06, 0.0717, 0.07, 0.0874 };

        // array that stores the cost per unit for particular product
        readonly double[] costPerUnit = { 7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58 };
        

        private void BtnCalculate_Click_1(object sender, EventArgs e)
        {
            //variables
            double dblInitialCost;
            double dblDiscountedCost = 0;
            double dblTax;
            double dblTotalCost;
            //take product number from the text box
            Int32.TryParse(txtProduct.Text, out int productNumber);
            if (productNumber >= 1001 && productNumber <= 1007)
            {
                Int32.TryParse(txtQuantity.Text, out int quantity);
                dblInitialCost = costPerUnit[(productNumber % 10) - 1] * quantity;
                if (quantity <= 5)
                    dblDiscountedCost = dblInitialCost;
                else if (quantity >= 6 && quantity <= 10)
                    dblDiscountedCost = dblInitialCost - dblInitialCost * 0.05;
                else if (quantity >= 11 && quantity <= 20)
                    dblDiscountedCost = dblInitialCost - dblInitialCost * 0.1;
                else if (quantity >= 21)
                    dblDiscountedCost = dblInitialCost - dblInitialCost * 0.15;

                dblTax = dblDiscountedCost * discountRates[cmbState.SelectedIndex];
                dblTotalCost = dblDiscountedCost + dblTax;

                lblInitialCost.Text = dblInitialCost.ToString("C2");
                lblDiscCost.Text = dblDiscountedCost.ToString("C2");
                lblTax.Text = dblTax.ToString("C2");
                lblTotalCost.Text = dblTotalCost.ToString("C2");
            }
            else
            {
                MessageBox.Show("Invalid product number.");
            }
        }
    }
}
