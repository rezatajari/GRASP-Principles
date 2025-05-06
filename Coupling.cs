using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASP_Principles
{
    internal class Coupling
    {
    }

    // High Coupling 
    internal class MyBookWithCoupling
    {
        public string Name { get; set; }
        public bool IsBorrowed { get; set; }

        public bool IsAvailable()
        {
            return !IsBorrowed;
        }
    }

    internal class LibraryCatalog
    {
        public void CheckAvailability(Book book)
        {
            // Directly tied to the Book class
            if (book.IsAvailable())
            {
                Console.WriteLine($"'{book.Name}' is available.");
            }
        }
    }


    // Low Coupling
    // Define abstraction
    internal interface ISearchable
    {
        string Name { get; }
        bool IsAvailable();
    }

    // MyBook implements the abstraction
    internal class MyBookDeCoupling:ISearchable
    {
        public string Name { get; }
        public bool IsBorrow { get; set; }

        public bool IsAvailable()
        {
            return IsBorrow;
        }
    }

    // LibraryCatalog depends only on the abstraction instead of MyBook class (coupling)
    internal class Search
    {
        public void SearchBook(ISearchable item)
        {
            if (item.IsAvailable())
            {
                Console.WriteLine("Book is available");
            }
            else
            {
                Console.WriteLine("Book is not available");
            }
        }
    }

}
