// Grading ID: A9931
// Program4
// 12/06/16
// CIS-199-01

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4
{
    public partial class Form1 : Form
    {
        List<LibraryBook> bookList = new List<LibraryBook>(); // List to hold LibraryBook objects

        LibraryBook myBook = new LibraryBook(); // LibraryBook Object

        bool isValid; // Holds a bool to allow the creation a a book if the input info was valid

        public Form1()
        {
            InitializeComponent();
        }

        //PreConditions:  Tittle textbox = string
        //                author textbox = string
        //                Publisher textbox = string
        //                Copyright textbox = int >= 0
        //                Call Number textbox = string

        //PostConditions: It assigns the data entered by the user to the object's properties
        //                if any of the textboxses are empty show a message, also if the input is invalid
        public void GetBook (LibraryBook book)
        {
            int copyright;  // Hold the value for copyright year

            if (string.IsNullOrEmpty(title_TXT.Text)) //check if the title textbox is empty
            {
                MessageBox.Show("Enter a Title!");
            }
            else if (string.IsNullOrEmpty(author_TXT.Text))
            {
                MessageBox.Show("Enter an Author!");
            }
            else if (string.IsNullOrEmpty(publisher_TXT.Text))
            {
                MessageBox.Show("Enter a Publisher!");
            }
            else if (string.IsNullOrEmpty(callNumber_TXT.Text))
            {
                MessageBox.Show("Enter a Call Number!");
            }
            else if (int.TryParse(copyright_TXT.Text, out copyright)) //TryParce the input of copyright
            {
                if (copyright >= 0) // check if the value of copyright is not negative
                {
                    //Get the book's details
                    book.Title = title_TXT.Text;
                    book.Author = author_TXT.Text;
                    book.Publisher = publisher_TXT.Text;
                    book.CopyrightYear = copyright;
                    book.CallNumber = callNumber_TXT.Text;

                    book.CheckedOutStatus = false; //assing the checkeout status to false to the item created

                    isValid = true; // Change the value of variable to true
                }
                else
                {
                    MessageBox.Show("Invalid Copyright Year!");
                }
            }
            else
                MessageBox.Show("Enter a Copyright Year!");

        }
        // PreCondition: User Clicked on add book
        // PostConditions: get the book data and add the book object to the list
        //                 add an entry to the list box after that clear textboxes and reset focus
        private void addBook_BTN_Click(object sender, EventArgs e)
        {
            isValid = false; //Every time the add book is clicked the value of the variable will change to false

        
            GetBook(myBook); // use the method to get the book data


            if (isValid == true) // check if the data entered was valid
            { 

            bookList.Add(myBook);// add the book object to the list

            books_LBX.Items.Add(myBook.Title); // add an entry to the list box

            // clear the textboxes
            title_TXT.Clear();
            author_TXT.Clear();
            publisher_TXT.Clear();
            copyright_TXT.Clear();
            callNumber_TXT.Clear();

            title_TXT.Focus(); // set focust back to title textbox
            }
        }

        //PreConditions: user clicked details button
        //               select a book
        //PostConditions: display details of the book selected
        private void details_BTN_Click(object sender, EventArgs e)
        {
            int index = books_LBX.SelectedIndex; // Hold the value of the selected item on the list box

            if (index >= 0) // check if a book was selected
                MessageBox.Show(bookList[index].ToString()); // display the selected item's details
            else
                MessageBox.Show("Enter a Book or Select a Book!");
        }

        // PreConditions: user clicked checkOut button
        //                select a book
        // PostConditions: change the value of isCheckedOut to True and display message
        private void checkOut_BTN_Click(object sender, EventArgs e)
        {
            int index = books_LBX.SelectedIndex; // Hold the value of the selected item on the list box

            if (index >= 0) // Check if a book was selected
            {
                bookList[index].CheckOut(); // change the value of isCheckedOut to true using the method in the selected item
                MessageBox.Show("The Book has been Checked Out succesfully!");
            }
            else
                MessageBox.Show("Enter a Book or Select a Book!");
        }

        //PreConditions: user clicked return button
        //               select a book
        // PostConditions: change the value of isCheckedOut to False and display message
        private void return_BTN_Click(object sender, EventArgs e)
        {
            int index = books_LBX.SelectedIndex; // Hold the value of the selected item on the list box

            if (index >= 0) // Check if a book was selected
            {
                bookList[index].ReturnToShelf(); // change the value of isCheckedOut to False using the method in the selected item
                MessageBox.Show("The Book has been Returned succesfully!");
            }
            else
                MessageBox.Show("Enter a Book or Select a Book!");
        }
    }
}
