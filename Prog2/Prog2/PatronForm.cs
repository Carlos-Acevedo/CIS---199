//Grading ID: D6571
//Program 2
//Due Date: 3/09/2017
//CIS-200-01

// The purpose of this form is to add a new patron to the library
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class PatronForm : Form
    {
        public PatronForm()
        {
            InitializeComponent();
        }
        public string NAME
        {
            // Precondition:  None
            // Postcondition: Text in patronName_TXT is returned
            get { return patronName_TXT.Text; }

            // Precondition:  None
            // Postcondition: Text in patronName_TXT is set to specified value
            set { patronName_TXT.Text = value; }
        }
        public string ID
        {
            // Precondition:  None
            // Postcondition: Text in patronID_TXT is returned
            get { return patronID_TXT.Text; }

            // Precondition:  None
            // Postcondition: Text in patronID_TXT is set to specified value
            set { patronID_TXT.Text = value; }
        }

        // Precondition:  Attempting to change focus from patronName_TXT_Validating
        // Postcondition: If entered value is valid string, focus will change,
        //                 else error message will be set
        private void patronName_TXT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(patronName_TXT.Text))
                e.Cancel = true; // Stops focus changing
            // Will NOT proceed to Validated event

            errorProvider1.SetError(patronName_TXT, "Must enter a Name!"); // Set error message

            patronName_TXT.SelectAll(); // Select all text in inputTxt to allow user to erase mistake
        }

        // Precondition:  patronName_TXT_Validating succeeded
        // Postcondition: ErrorMessage has been cleared, and the user can shift focus can continue on their way
        private void patronName_TXT_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(patronName_TXT, ""); // Clears error message
        }

        // Precondition:  Attempting to change focus from patronID_TXT_Validating
        // Postcondition: If entered value is valid string, focus will change,
        //                 else error message will be set
        private void patronID_TXT_Validating(object sender, CancelEventArgs e)
        {
            int number; // ID entered into id-txt

            if(!int.TryParse(patronID_TXT.Text, out number))
            {
                e.Cancel = true; // Stops focus changing

                errorProvider1.SetError(patronID_TXT, "Enter an integer!");

                patronID_TXT.SelectAll(); // Select all text in inputTxt to allow user to erase mistake
            }
        }

        // Precondition:  patronID_TXT_Validated succeeded
        // Postcondition: ErrorMessage has been cleared, and the user can shift focus can continue on their way
        private void patronID_TXT_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(patronID_TXT, "");
        }

        // Precondition:  User has initiated click on patronCancel_BTN
        // Postcondition: If left-click, PatronForm is eneded with Cancel result
        private void patronCancel_BTN_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
                DialogResult = DialogResult.Cancel;
        }
        // Precondition:  User clicked on patronOk_BTN
        // Postcondition: PatronForm is eneded with OK result
        private void patronOk_BTN_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                DialogResult = DialogResult.OK;
        }
    }
}
