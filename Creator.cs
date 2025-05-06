using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASP_Principles
{
    internal class Creator
    {
    }

    internal class Library
    {
        List<Book> books = new List<Book>();

        public void AddBook(string name, string author, string categoryName)
        {
            var newBook=Book.Create(name, author, categoryName);
            books.Add(newBook);
        }
    }
}
