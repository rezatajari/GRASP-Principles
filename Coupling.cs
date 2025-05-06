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

    // Define abstraction
    internal interface ISearchable
    {
        string Name { get; }
        bool IsAvailable();
    }

    // MyBook implements the abstraction
    internal class MyBook:ISearchable
    {
        public string Name { get; }
        public bool IsBarrow { get; set; }

        public bool IsAvailable()
        {
            return IsBarrow;
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
