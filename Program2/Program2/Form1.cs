//Grading ID:A9931
//Program2
//Due Date: 10/16/2016
//CIS-199-01
//Description: The user will enter his/her last name and credit hours and it will output when he/she can register for classes.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string time; //registration time
        string date; //registration date

        //Show the date and time the user registers when clicking the OK button.
        private void oK_BTN_Click(object sender, EventArgs e)
        {

            double creditHours; // Hold number of credit hours.
            string name = lastName_TXT.Text; // string for the last name texbox input.
            char firstLetter; // Hold first letter of the name texbox.


            //Input
            firstLetter = char.ToLower(name[0]); //replaces first letter from string and converts it to lowrcase.

            if (double.TryParse(creditHours_TXT.Text, out creditHours)) //Verify data for credit hours input, if incorrect, show error message.
            {
                // Registration dates and times for Freshman and Sophomores
                if(creditHours < 60)
                {
                    if(firstLetter >= 'a')
                    {
                        time = "10:00am.";
                    }
                    if (firstLetter >= 'c')
                    {
                        time = "11:30am.";
                    }
                    if(firstLetter >= 'e')
                    {
                        time = "2:00pm.";
                    }
                    if (firstLetter >= 'g')
                    {
                        time = "4:00pm.";
                    }
                    if (firstLetter >= 'j')
                    {
                        time = "8:30am.";
                    }
                    if (firstLetter >= 'm')
                    {
                        time = "10:00am.";
                    }
                    if (firstLetter >= 'p') 
                    {
                        time = "11:30am.";
                    }
                    if (firstLetter >= 'r')
                    {
                        time = "2:00pm.";
                    }
                    if (firstLetter >= 't')
                    {
                        time = "4:00pm.";
                    }
                    if (firstLetter >= 'w')
                    {
                        time = "8:30am.";
                    }

                    //Dates for Sophomores
                    if (creditHours >= 30)
                    {
                        if (firstLetter >= 'j' && firstLetter <= 'v')
                        {
                            date = "Wednesday, November 9th";
                        }
                        else if (firstLetter <= 'i' || firstLetter >= 'w')
                        {
                            date = "Thursday, November 10th";
                        }
                    }

                }

                // Registration dates and times for Juniors and Senious
                if (creditHours >= 60)
                {
                    if(firstLetter >= 't')
                    {
                        time = "11:30am.";
                    }
                    else if (firstLetter >= 'p')
                    {
                        time = "10:00am.";
                    }
                    else if (firstLetter >= 'j')
                    {
                        time = "8:30am.";
                    }
                    else if (firstLetter >= 'e')
                    {
                        time = "4:00pm.";
                    }
                    else if (firstLetter >= 'a')
                    {
                        time = "2:00pm.";
                    }
                    
                    date = "Monday, November 7th"; //Registration date for Juniors

                    if (creditHours >= 90)
                    {
                        date = "Friday, November 4th"; //Registration date for Seniors
                    }
                }
            }else
            {
                MessageBox.Show("Enter a number for Credit Hours"); //Show error message when input incorrect for credit Hours.
            }

            scheduleOutPut_LBL.Text = date + " " + "at" + " " + time; //Concatenate variables and display output

        }

        //Clear input/output when you click the clear button.
        private void clear_BTN_Click(object sender, EventArgs e)
        {

            creditHours_TXT.Clear();//clear input for credit hours
            lastName_TXT.Clear();//clear input for last name
            scheduleOutPut_LBL.Text = "";//clear output

            lastName_TXT.Focus();//set focus on last name after clearing input/output.
        }
    }
}
