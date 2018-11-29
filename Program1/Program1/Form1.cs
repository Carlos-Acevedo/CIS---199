//Grading ID:A9931
//Program1
//Due Date: 9/27/2016
//CIS-199-01
/*the User will enter the square feet of wall space to be painted,
 the number of cats of paint desired, and the price of the paint per gallon.
 The program shoud diplay various calculations*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class Form1 : Form
    {
        // Constant fields
        const double SQUARE_FEET = 275;
        const double HOURS_OF_LABOR = 8;
        const double HOUR_RATE = 12.5;

        public Form1()
        {
            InitializeComponent();
        }

        //By clicking the button it will generate the calculations

        private void generateQuote_BTN_Click(object sender, EventArgs e)
        {
            double sqrft;               //Variable for square feet
            double coatsOfPaintToApply; //Variable for coats of paint to apply
            double pricePerGallon;      //Variable for gallons
            double totalSquareFeet;     //Variable for tital square feet
            double gallonsNeeded;       //Variable for gallons needed
            double hoursofLaborNeeded;  //Variable for hours of labor needed
            double paintCost;           //Variable for cost of paint
            double laborCost;           //Variable for labor charge
            double totalCost;           //Variable for total cost         

            //Parce square feet of wall sapace
            sqrft = double.Parse(squareFeetInputTXT.Text);
            coatsOfPaintToApply = double.Parse(coatsofPaintInputTXT.Text);
            pricePerGallon = double.Parse(pricePerGallonTXT.Text);

            //Calculate the integers
            totalSquareFeet = sqrft * coatsOfPaintToApply;
            gallonsNeeded = Math.Ceiling (sqrft / SQUARE_FEET)*coatsOfPaintToApply;
            hoursofLaborNeeded = (totalSquareFeet/SQUARE_FEET)*HOURS_OF_LABOR;
            paintCost = (gallonsNeeded * pricePerGallon);
            laborCost = (hoursofLaborNeeded * HOUR_RATE);
            totalCost = (paintCost + laborCost);

            //Distplay content
            totalSquareFeetOutput_LBL.Text = totalSquareFeet.ToString("f1");
            gallonsNeededOutput_LBL.Text = gallonsNeeded.ToString();
            hoursofLaborOutput_LBL.Text = hoursofLaborNeeded.ToString("n1");
            paintCostOutput_LBL.Text = paintCost.ToString("c");
            laborCostOutput_LBL.Text = laborCost.ToString("c");
            totalCostOutput_LBL.Text = totalCost.ToString("c");
                    
        }
    }
}
