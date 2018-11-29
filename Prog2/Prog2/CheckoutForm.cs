//Grading ID: D6571
//Program 2
//Due Date: 3/09/2017
//CIS-200-01

// The purpose of this form is to select a book to checkout by a patron

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
    public partial class CheckoutForm : Form
    {
        public CheckoutForm(List<LibraryItem> itemsList, List<LibraryPatron> patronList)
        {
            InitializeComponent();

            //Displays every item that has been checked out in the item_ComboBox
            foreach (var item in itemsList)
            {
                item_ComboBox.Items.Add($"{item.Title}, {item.CallNumber}{Environment.NewLine}");
            }
            ///Displays every patron that has been been registered with the library in the patron_ComboBox 
            foreach (var patron in patronList)
            {
                patron_ComboBox.Items.Add($"{patron.PatronName}, {patron.PatronID}{Environment.NewLine}");
            }
        }
        // Precondition:  None
        // Postcondition: Item in item_ComboBox is returned
        public int ITEM
        {
            get { return item_ComboBox.SelectedIndex; }

        }
        // Precondition:  None
        // Postcondition: Item in patron_ComboBox is returned
        public int PATRON
        {
            get { return patron_ComboBox.SelectedIndex; }
        }

        private void item_ComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (item_ComboBox.SelectedIndex < 0)
                e.Cancel = true; // Stops focus changing 

            CheckOutError.SetError(item_ComboBox, "Must select an item!"); // Set error message

            item_ComboBox.SelectAll();
        }
        // Precondition:  item_ComboBox_Validated Succeeded
        // Postcondition: ErrorMessage has been cleared, and the user can shift focus and continue on their way
        private void item_ComboBox_Validated(object sender, EventArgs e)
        {
            CheckOutError.SetError(item_ComboBox, ""); // Clears error message
        }
        // Precondition:  Attempting to change focus from patron_ComboBox_Validating
        // Postcondition: If patronBoxCbo.selectedIndex >= 0, focus will change,
        //                 else error message will be set    
        private void patron_ComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (patron_ComboBox.SelectedIndex < 0)
                e.Cancel = true; // Stops focus changing

            CheckOutError.SetError(patron_ComboBox, "Must select an patron!"); // Set error message

            patron_ComboBox.SelectAll();
        }
        // Precondition:  patron_ComboBox_Validated Succeeded
        // Postcondition: ErrorMessage has been cleared, and the user can shift focus and continue on their way
        private void patron_ComboBox_Validated(object sender, EventArgs e)
        {
            CheckOutError.SetError(patron_ComboBox, ""); // Clears error message
        }
        // Precondition:  User has initiated click on checkoutCancel_BTN
        // Postcondition: If left-click, CheckoutForm is eneded with with Cancel result
        private void checkoutCancel_BTN_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                DialogResult = DialogResult.Cancel;
        }
        // Precondition:  User has clicked on Ok Button
        // Postcondition: CheckoutForm is eneded with with OK result
        private void checkoutOK_BTN_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
