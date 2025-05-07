using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASP_Principles
{
    internal class Information
    {
    }

    internal class Book
    {

        public static Book Create(string name, string author, string categoryName)
        {
            return new Book { Name = name, Author = author, CategoryName = categoryName };
        }

        private Book() { }
        public string Name { get; private set; }
        public string CategoryName { get; private set; }
        public string Author { get; private set; }
        public bool IsBarrow { get; private set; }
        public string Type { get; set; }

        public bool IsAvailable()
        {
            return IsBarrow;
        }

        public void Barrow()
        {
           IsBarrow= true;
        }

        public void Return()
        {
            IsBarrow = false;
        }

    }
}
