// Program 4
// CIS 200-01
// Due: 4/19/2017
// By: D6571

// File: DescendingOrderCopyright
// compares the Library Items by Copyright year and returns them in descending order
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    // Compares by CopyrightYear
    public class DescendingOrderCopyright : Comparer<LibraryItem>
    {
        // Precondition:  None
        // Postcondition: Reverses natural time order, so descending
        //                When x < y, method returns positive #
        //                When x == y, method returns zero
        //                When x > y, method returns negative #
        public override int Compare(LibraryItem x, LibraryItem y)
        {
            if (x.CopyrightYear.CompareTo(y.CopyrightYear) != 0)    // Different CopyrightYear?
            {
                return x.CopyrightYear.CompareTo(y.CopyrightYear);  // Use CopyrightYear to decide
            }
            else
                return (-1) * x.CompareTo(y); // Reverses natural order, so descending
        }
    }
}
