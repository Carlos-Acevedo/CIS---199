//Grading ID: D6571
//Program 2
//Due Date: 3/09/2017
//CIS-200-01

// The purpuse of this form is to selcet items to return
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
    public partial class ReturnForm : Form
    {
        public ReturnForm(List<LibraryItem> itemsList)
        {
            InitializeComponent();

            //Finds and displays the items that have been checked out.
            var checkedOutItems =
                from item in itemsList
                where item.IsCheckedOut()
                select item;
            //Displays every item that has been checked out in the returnItem_ComboBox
            foreach (var item in checkedOutItems)
            {
                returnItem_ComboBox.Items.Add($"{item.Title}, {item.CallNumber}{Environment.NewLine}");
            }
        }
        public int Item
        {
            // Precondition:  None
            // Postcondition: Item in returnItem_ComboBox is returned
            get { return returnItem_ComboBox.SelectedIndex; }
        }

        // Precondition:  Attempting to change focus from returnItemCbo_Validating
        // Postcondition: If returnItem_ComboBox.selectedIndex >= 0, focus will change,
        //                 else error message will be set        
        private void returnItem_ComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (returnItem_ComboBox.SelectedIndex < 0)
                e.Cancel = true; // Stops focus changing

            returnError.SetError(returnItem_ComboBox, "Must select an item!"); // Set message error

        }
        // Precondition:  returnItem_ComboBox_Validated succeeded
        // Postcondition: ErrorMessage has been cleared, and the user can shift focus can continue on their way
        private void returnItem_ComboBox_Validated(object sender, EventArgs e)
        {
            returnError.SetError(returnItem_ComboBox, ""); // Clears error message
        }
        // Precondition:  User has initiated click on returnCancel_BTN
        // Postcondition: If left-click, ReturnForm is eneded with with Cancel result
        private void returnCancel_BTN_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                DialogResult = DialogResult.Cancel;
        }
        // Precondition:  User has clicked on Ok Button
        // Postcondition: ReturnForm is eneded with with OK result
        private void returnOK_BTN_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                DialogResult = DialogResult.OK;
        }
    }
}
