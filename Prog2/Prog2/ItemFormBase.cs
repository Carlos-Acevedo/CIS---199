//Grading ID: D6571
//Program 2
//Due Date: 3/09/2017
//CIS-200-01

// This Program explores the creation of simple GUI, use of dialog boxes, validation, and exception handling.

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
    public partial class ItemFormBase : Form
    {
        // Library to hold the test data
        private Library newLibrary;

        public ItemFormBase()
        {
            InitializeComponent();
            //instatiate the test library
            newLibrary = new Library();

            //Test data for the library
            newLibrary.AddLibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,
            "ZZ25 3G", "Andrew Wright");
            newLibrary.AddLibraryBook("Harriet Pooter", "Stealer Books", 2000, 21,
                "AB73 ZF", "IP Thief");
            newLibrary.AddLibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7,
                "MM33 2D", 92.5, "Andrew L. Wright", LibraryMediaItem.MediaType.BLURAY,
                LibraryMovie.MPAARatings.PG);
            newLibrary.AddLibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2012, 10,
                "MO93 4S", 122.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G);
            newLibrary.AddLibraryMusic("C# - The Album", "UofL Music", 2014, 14,
                "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10);
            newLibrary.AddLibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
                "VI64 1Z", 65.0, "Cee Sharpe", LibraryMediaItem.MediaType.VINYL, 12);
            newLibrary.AddLibraryJournal("Journal of C# Goodness", "UofL Journals", 2000, 14,
                "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright");
            newLibrary.AddLibraryJournal("Journal of VB Goodness", "UofL Journals", 2008, 14,
                "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams");
            newLibrary.AddLibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
                "MA53 9A", 16, 7);
            newLibrary.AddLibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
                "MA53 9B", 16, 8);
            newLibrary.AddLibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
                "MA53 9C", 16, 9);
            newLibrary.AddLibraryMagazine("VB Magazine", "UofL Mags", 2017, 14,
                "MA21 5V", 1, 1);
            newLibrary.AddPatron("Ima Reader", "12345");
            newLibrary.AddPatron("Jane Doe", "11223");
            newLibrary.AddPatron("John Smith", "54321");
            newLibrary.AddPatron("James T. Kirk", "98765");
            newLibrary.AddPatron("Jean-Luc Picard", "33456");


        }
        // Precondition:  None
        // Postcondition: Shows about menu with information such as Gradin ID, due date, etc.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grading ID: D6571\nProgram 2\nDue date: 3/09/17\nCIS-200-01");
        }
        // Precondition:  None
        // Postcondition: Will close program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  None
        // Postcondition: Adds new patron to the list of patron's in the library's linq list.
        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creates the patron subform and opens it
            PatronForm patronForm = new PatronForm();
            DialogResult result; // Holds dialog result
            string name; // Holds the name of the new patron
            string id; // Holds the ID of the new patron
            result = patronForm.ShowDialog();

            if (result == DialogResult.OK) // Update when user clicks OK
            {
                name = patronForm.NAME;
                id = patronForm.ID;
                newLibrary.AddPatron(name, id);
            }
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creates the book subform and opens it.
            BookForm bookForm = new BookForm();
            DialogResult result;//Holds the dialog result
            string title;//holds the title of the book
            string publisher;//holds the publisher of the book
            int copyRightYear;//holds the copyRightYear of the book
            int loanPeriod;//holds the loanPeriod of the book
            string callNum;//holds the callNum of the book
            string author;//holds the author of the book

            result = bookForm.ShowDialog();

            if (result == DialogResult.OK) // Update when user clicks OK
            {
                title = bookForm.Title;
                publisher = bookForm.Publisher;
                copyRightYear = int.Parse(bookForm.CopyRightYear);
                loanPeriod = int.Parse(bookForm.LoanPeriod);
                callNum = bookForm.CallNumber;
                author = bookForm.Author;

                newLibrary.AddLibraryBook(title, publisher, copyRightYear, loanPeriod, callNum, author);
            }
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sends the items, and patrons list to the checkout subform
            CheckoutForm checkoutForm = new CheckoutForm(newLibrary._items, newLibrary._patrons);
            DialogResult result;//holds the dialog result
            int item;//holds the item index
            int patron;//holds the patron index


            result = checkoutForm.ShowDialog();

            if (result == DialogResult.OK)// Only update if user chose OK from dialog box
            {
                item = checkoutForm.ITEM;
                patron = checkoutForm.PATRON;
                newLibrary.CheckOut(item, patron);

            }
        }
        // Precondition:  None
        // Postcondition: Return's the items that the user selects to return from the subform Returnform.
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sends the items list to the return subform
            ReturnForm returnForm = new ReturnForm(newLibrary._items);
            DialogResult result;//holds the dialog result
            int item;//holds the item index

            result = returnForm.ShowDialog();

            if (result == DialogResult.OK)// Only update if user chose OK from dialog box
            {

                item = returnForm.Item;
                newLibrary.ReturnToShelf(item);

            }
        }
        // Precondition:  None
        // Postcondition: Displays the list of patrons in the library.
        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itemFormBase_TXT.Clear();

            //Displays every patron registerd for the library
            foreach (LibraryPatron patron in newLibrary._patrons)
                itemFormBase_TXT.Text += $"{patron}{Environment.NewLine}{Environment.NewLine}";
        }

        // Precondition:  None
        // Postcondition: Displays the list of items in the library.
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itemFormBase_TXT.Clear();
            itemFormBase_TXT.Text += $"The amount of items in the list is: {newLibrary.GetItemCount()}{Environment.NewLine}";

            //Displays every item that the library owns
            foreach (LibraryItem item in newLibrary._items)
                itemFormBase_TXT.Text += $"{Environment.NewLine}{item}{Environment.NewLine}";
        }
        // Precondition:  None
        // Postcondition: Displays the list of items that have been checkedout from the library.
        private void checkedOutItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itemFormBase_TXT.Clear();

            //Finds and displays the items that have been checked out.
            var checkedOutItems =
                from item in newLibrary._items
                where item.IsCheckedOut()
                select item;

            itemFormBase_TXT.Text += $"The amount of items in the list is: {checkedOutItems.Count()}{Environment.NewLine}";

            //Displays every item that has been checked out
            foreach (LibraryItem item in checkedOutItems)
                itemFormBase_TXT.Text += $"{Environment.NewLine}{item}{Environment.NewLine}";
        }
    }
}
