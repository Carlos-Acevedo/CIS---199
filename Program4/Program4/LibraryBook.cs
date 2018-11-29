// Grading ID: A9931
// Program4
// 12/06/16
// CIS-199-01

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    public class LibraryBook
    {
        // Backing fields
        private string _title;          //Title
        private string _author;         //Author
        private string _publisher;      //Publisher
        private int _copyrightyear;     //CopyrightYear
        private string _callnumber;     //CallNumber
        private bool _checkedoutstatus; //CheckedOutStatus

        // Precondition: values have to have text, cr >= 0
        // Postcondition: The Library Book has been initialized
        public LibraryBook(string t="", string a="", string p="",
                            int cr=2016, string cn="", bool co=false)
        {
            Title = t;
            Author = a;
            Publisher = p;
            CopyrightYear = cr;
            CallNumber = cn;
            CheckedOutStatus = co;
        }

        //Precondition: enter text
        //Postcondition: the title has been returnd and it
        //               has been set to the specified value
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        //Precondition: enter text
        //Postcondition: the title has been returnd and it
        //               has been set to the specified value
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        //Precondition: enter text
        //Postcondition: the Publisher has been returnd and it
        //               has been set to the specified value
        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        public int CopyrightYear
        {

            //Precondition: None
            //Postcondition: the copyrightyear has been returned
            get
            {
                return _copyrightyear;
            }

            //Precondition: value >= 0
            //Postcondition: the copyright year has been set to the specified value
            set
            {
                if (value >= 0)
                    _copyrightyear = value;
                else
                    _copyrightyear = 2016;
            }

        }

        //Precondition: enter text
        //Postcondition: the CallNumber has been returnd and it
        //               has been set to the specified value
        public string CallNumber
        {
            get { return _callnumber; }
            set { _callnumber = value; }
        }

        public bool CheckedOutStatus
        {
            //Precondition: None
            //Postcondition: the CheckedOutStatus has been returned
            get
            {
                return _checkedoutstatus;
            }
            //Precondition: None
            //Postcondition: the CheckedOutStatus has been set tot the specified value
            set
            {
                _checkedoutstatus = value;
            }
        }

        //Precondition: None
        //Postcondition: change the checkedoutstatus true
        public void CheckOut()
        {
            _checkedoutstatus = true;
        }
        //Precondition: None
        //Postcondition: change the checkedoutstatus false
        public void ReturnToShelf()
        {
           _checkedoutstatus = false;
        }
        //Precondition: None
        //Postcondition: the checkedoutstatus has been returned
        public bool IsCheckedOut()
        {
            return _checkedoutstatus;
        }

        //Precondition: None
        //Postcondition: A string is returned showing the book's details
        public override string ToString()
        {
            return "Title:  " + Title.ToString()+ "\n" + "Author:  " + Author.ToString() + "\n" +
                "Publisher:  " + Publisher.ToString() + "\n" + "Copyright Year:  " + CopyrightYear.ToString() + "\n"
                + "Call Number:  " + CallNumber.ToString() + "\n" + "Checked Out Status: " + CheckedOutStatus.ToString();
        }

    }
}
