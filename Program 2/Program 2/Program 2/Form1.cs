//ID R8507
// Program 2
// Due 3/11/2021
// CIS 199-01
using System;
using System.Windows.Forms;

namespace select_best_option
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtPeople.Text, out double people) || people < 0)
            {
                MessageBox.Show("Invalid Number of people");
            }
            else if (!double.TryParse(txtMile.Text, out double mile) || mile < 0)
            {
                MessageBox.Show("Invalid Distance");
            }
            else if (!int.TryParse(txtDay.Text, out int days) || days < 0)
            {
                MessageBox.Show("Invalid Delivery Days");
            }
            else
            {
                double company1peopleCost = 1 * people;
                double company1MlleCost = .02 * mile;
                double company1DayCost;
                if (days == 1)
                    company1DayCost = 20;
                else if (days == 2)
                    company1DayCost = 17;
                else if (days == 3)
                    company1DayCost = 15;
                else if (days >= 4 && days <= 7)
                    company1DayCost = 10;
                else
                    company1DayCost = 7;

                //Company1 Cost 
                double company1TotalCost = company1DayCost + company1MlleCost + company1peopleCost;
                double company2peopleCost;
                if (people < 10)
                    company2peopleCost = 20;
                else if (people >= 10 && people < 50)
                    company2peopleCost = 10;
                else if (people >= 50 && people < 100)
                    company2peopleCost = 5;
                else if (people >= 100 && people < 200)
                    company2peopleCost = 3;
                else
                    company2peopleCost = people * 0.15;
                double company2MlleCost = .10 * mile;
                double company2DayCost;
                if (days >= 1 && days <= 4)
                    company2DayCost = 10;
                else
                    company2DayCost = 7;

                //Company2 Cost
                double company2TotalCost = company2DayCost + company2MlleCost + company2peopleCost;
                double company3peopleCost = people * 0.25;
                double company3MlleCost;
                if (mile >= 0 && mile < 200)
                    company3MlleCost = 10;
                else if (mile >= 200 && mile < 500)
                    company3MlleCost = 15;
                else if (mile >= 500 && mile < 750)
                    company3MlleCost = 25;
                else if (mile >= 750 && mile < 1000)
                    company3MlleCost = 35;
                else
                    company3MlleCost = 40;

                double company3DayCost = 20;

                //Company3 cost
                double company3TotalCost = company3DayCost + company3MlleCost + company3peopleCost;

                //Finding cost
                double best_cost = company1TotalCost;
                string best_company = "CompanyA";

                if (company2TotalCost < best_cost && company2TotalCost < company3TotalCost)
                {
                    best_cost = company2TotalCost;
                    best_company = "CompanyB";
                }
                if (company3TotalCost < best_cost && company3TotalCost < company2TotalCost)
                {
                    best_company = "CompanyC";
                }
                lblResult.Text = "CompanyA cost: " + company1TotalCost.ToString("C")
                    + "\nCompanyB cost: " + company2TotalCost.ToString("C")
                    + "\nCompanyC cost: " + company3TotalCost.ToString("C")
                   + "\nThe lowest cost company is " + best_company;

            }


        }
    }
}