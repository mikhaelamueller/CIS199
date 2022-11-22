// Grading ID: R8507
//Program 1
//Due: 2/16/2021
// CIS 199-01
using System;

namespace Program1
{
    class Program
    {
        private static void Main()
        {
            //user inputs
            const double FIRST_GARDEN_CHARGE = 50.00, SQUARE_YARD = 9.0, EXCESS = 0.10
                , FERT__CHARGE = 4.25, LABOR_CHARGE = 3.25;
            double totalCost = 0, fertCost = 0, soilCost = 0,
                laborCost = 0;
            Console.WriteLine("Welcome to the EZ-Garden and Landscaping Costs Estimator"); //Greeting statement
            Console.Write("Enter the max width of garden (in feet): "); //user inputs width of garden
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter the max length of garden (in feet): "); //user inputs length of garden
            double length = double.Parse(Console.ReadLine());
            Console.Write("Enter the soil price(per sq. yard): "); // user inputs soil price
            double price = double.Parse(Console.ReadLine());
            Console.Write("Enter the whether fertilizer is needed (1 - YES, 0 - NO): "); //user inputs integers for whether fertilizer is needed
            int fertilizer = int.Parse(Console.ReadLine());
            Console.Write("Is this the first garden? (1 - YES, 0 - NO): "); //user inputs integers for whether its the first garden or not
            int firstGarden = int.Parse(Console.ReadLine());

            //calculations
            double area = (length * width) / SQUARE_YARD; // area of garden
            soilCost = price * area; //cost of soil without excess
            soilCost = soilCost + soilCost * EXCESS; // cost of soil with excess

            if (fertilizer == 1)
            {
                fertCost = FERT__CHARGE * area; // calculation of fertilizer cost
            }
            if (firstGarden == 1)
                laborCost = FIRST_GARDEN_CHARGE; 

            laborCost += LABOR_CHARGE * area; // cost of labor calculation

            totalCost = soilCost + fertCost + laborCost;

            //display result
            Console.WriteLine(String.Format("{0,-25:s} {1, 10:F1}", "Sq. Yards Needed:", area)); // label for square yards needed
            Console.WriteLine(String.Format("{0,-25:s} {1, 10:C}", "Soil Cost:", soilCost)); // shows the cost of soil
            Console.WriteLine(String.Format("{0,-25:s} {1, 10:C}", "Fertilizer Cost:", fertCost)); // shows the fertilizer cost
            Console.WriteLine(String.Format("{0,-25:s} {1, 10:C}", "Labor Cost:", laborCost)); // shows the labor cost
            Console.WriteLine(String.Format("{0,-25:s} {1, 10:C}", "Total Cost:", totalCost)); // shows the total cost
        }
    }
}
         
