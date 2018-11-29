//Grading ID: D6571
//Program 2
//Due Date: 3/09/2017
//CIS-200-01

// The purpose of this form is to add a new book to the library
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
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        public string Title
        {
            // Precondition:  None
            // Postcondition: Text in bookTitle_TXT is returned
            get { return bookTitle_TXT.Text; }

            // Precondition:  None
            // Postcondition: Text in bookTitle_TXT is set to specified value
            set { bookTitle_TXT.Text = value; }
        }
        public string Publisher
        {
            // Precondition:  None
            // Postcondition: Text in bookPublisher_TXT is returned
            get { return bookPublisher_TXT.Text; }

            // Precondition:  None
            // Postcondition: Text in bookPublisher_TXT is set to specified value
            set { bookPublisher_TXT.Text = value; }
        }
        public string CopyRightYear
        {
            // Precondition:  None
            // Postcondition: Text in cbookCopyrightYear_TXT is returned
            get { return bookCopyrightYear_TXT.Text; }

            // Precondition:  None
            // Postcondition: Text in bookCopyrightYear_TXT is set to specified value
            set { bookCopyrightYear_TXT.Text = value; }
        }
        public string LoanPeriod
        {
            // Precondition:  None
            // Postcondition: Text in bookLoanPeriod_TXT is returned
            get { return bookLoanPeriod_TXT.Text; }

            // Precondition:  None
            // Postcondition: Text in bookLoanPeriod_TXT is set to specified value
            set { bookLoanPeriod_TXT.Text = value; }
        }
        public string CallNumber
        {
            // Precondition:  None
            // Postcondition: Text in bookCallNumber_TXT is returned
            get { return bookCallNumber_TXT.Text; }

            // Precondition:  None
            // Postcondition: Text in bookCallNumber_TXT is set to specified value
            set { bookCallNumber_TXT.Text = value; }
        }
        public string Author
        {
            // Precondition:  None
            // Postcondition: Text in bookAuthor_TXT is returned
            get { return bookAuthor_TXT.Text; }

            // Precondition:  None
            // Postcondition: Text in bookAuthor_TXT is set to specified value
            set { bookAuthor_TXT.Text = value; }
        }
        // Precondition:  Attempting to change focus from bookTitle_TXT_Validating
        // Postcondition: If entered value is valid string, focus will change,
        //                else error message will be set
        private void bookTitle_TXT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(bookTitle_TXT.Text))
                e.Cancel = true; // Stops focus changing

            bookError.SetError(bookTitle_TXT, "Must enter a Title!"); // Set error message
            bookTitle_TXT.SelectAll(); // Select all text to erase mistake
        }
        // Precondition:  bookTitle_TXT_Validated succeeded
        // Postcondition: ErrorMessage has been cleared, and the user can shift focus can continue on their way
        private void bookTitle_TXT_Validated(object sender, EventArgs e)
        {
            bookError.SetError(bookTitle_TXT, ""); // Clears error message
        }
        // Precondition:  Attempting to change focus from bookPublisher_TXT_Validating
        // Postcondition: If entered value is valid string, focus will change,
        //               else error message will be set
        private void bookPublisher_TXT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(bookPublisher_TXT.Text))
                e.Cancel = true; // Stops focus changing 

            bookError.SetError(bookPublisher_TXT, "Must enter a Publisher!"); // Set error message
            bookPublisher_TXT.SelectAll(); // Select all text to erase mistake
        }
        // Precondition:  Attempting to change focus from bookCopyrightYear_TXT_Validating
        // Postcondition: If entered value is valid int, focus will change,
        //                 else error message will be set
        private void bookCopyrightYear_TXT_Validating(object sender, CancelEventArgs e)
        {
            int number;
            if ( int.TryParse(bookCopyrightYear_TXT.Text, out number))
            {
                if (number > 0)
                {
                    e.Cancel = false; // Allows focus changing
                }
                else
                {
                    e.Cancel = true; // Stops focus changing 
                    bookError.SetError(bookCopyrightYear_TXT, "Must enter a valid Copyright Year!"); // Set error message
                    bookCopyrightYear_TXT.SelectAll(); // Select all text to erase mistake
                }
            }
            else
            {
                e.Cancel = true; // Stops focus changing
                bookError.SetError(bookCopyrightYear_TXT, "Must enter a valid Copyright Year!"); // Set error message
                bookCopyrightYear_TXT.SelectAll(); // Select all text to erase mistake
            }
        }
        // Precondition:  bookCopyrightYear_TXT_Validated succeeded
        // Postcondition: ErrorMessage has been cleared, and the user can shift focus can continue on their way
        private void bookCopyrightYear_TXT_Validated(object sender, EventArgs e)
        {
            bookError.SetError(bookCopyrightYear_TXT, ""); // Clears error message
        }
        // Precondition:  Attempting to change focus from bookLoanPeriod_TXT_Validating
        // Postcondition: If entered value is valid int, focus will change,
        //               else error message will be set
        private void bookLoanPeriod_TXT_Validating(object sender, CancelEventArgs e)
        {
            int number;
            if (int.TryParse(bookLoanPeriod_TXT.Text, out number))
            {
                if (number > 0)
                {
                    e.Cancel = false; // Allows focus changing
                }
                else
                {
                    e.Cancel = true; // Stops focus changing
                    bookError.SetError(bookLoanPeriod_TXT, "Must enter a valid Loan Period!"); // Set error message
                    bookLoanPeriod_TXT.SelectAll(); // Select all text to erase mistake
                }
            }
            else
            {
                e.Cancel = true; // Stops focus changing
                bookError.SetError(bookLoanPeriod_TXT, "Must enter a valid Loan Period!"); // Set error message
                bookLoanPeriod_TXT.SelectAll(); // Select all text to erase mistake
            }
        }

        private void bookLoanPeriod_TXT_Validated(object sender, EventArgs e)
        {
            bookError.SetError(bookLoanPeriod_TXT, ""); // Clears error message
        }
        // Precondition:  Attempting to change focus from bookCallNumber_TXT_Validating
        // Postcondition: If entered value is valid string, focus will change,
        //                else error message will be set
        private void bookCallNumber_TXT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(bookCallNumber_TXT.Text))
                e.Cancel = true; // Stops focus changing 

            bookError.SetError(bookCallNumber_TXT, "Must enter a CallNumber!"); // Set error message
            bookCallNumber_TXT.SelectAll(); // Select all text to erase mistake
        }
        // Precondition:  bookCallNumber_TXT_Validated succeeded
        // Postcondition: ErrorMessage has been cleared, and the user can shift focus can continue on their way
        private void bookCallNumber_TXT_Validated(object sender, EventArgs e)
        {
            bookError.SetError(bookCallNumber_TXT, ""); // Clear error message
        }
        // Precondition:  Attempting to change focus from bookAuthor_TXT_Validating
        // Postcondition: If entered value is valid string, focus will change,
        //                 else error message will be set
        private void bookAuthor_TXT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(bookAuthor_TXT.Text))
                e.Cancel = true; // Stops focus changing

            bookError.SetError(bookAuthor_TXT, "Must enter an Author!"); // Set error message
            bookAuthor_TXT.SelectAll(); // Select all text to erase mistake
        }
        // Precondition:  bookAuthor_TXT_Validated succeeded
        // Postcondition: ErrorMessage has been cleared, and the user can shift focus can continue on their way
        private void bookAuthor_TXT_Validated(object sender, EventArgs e)
        {
            bookError.SetError(bookAuthor_TXT, ""); // Clear error message
        }
        // Precondition:  User has initiated click on bookCancel_BTN
        // Postcondition: If left-click, BookForm is eneded with with Cancel result
        private void bookCancel_BTN_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                DialogResult = DialogResult.Cancel;
        }

        private void bookOK_BTN_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                DialogResult = DialogResult.OK;
        }
    }
}
