using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASP_Principles
{
    internal class Polymorphism
    {
    }

    // Polymorphism failed
    internal class BorrowService
    {
        public void Borrow(Book book)
        {
            if (book.Type == "Fiction")
            {
                // special logic A
            }
            else if (book.Type == "NonFiction")
            {
                // special logic B
            }
        }
    }


    // Polymorphism passed
    internal abstract class OurBook
    {
        public string Title { get; set; }
        public abstract int GetMaxBarrowDays();
    }

    internal class Fiction : OurBook
    {
        public override int GetMaxBarrowDays()
        {
            return 38;
        }
    }
    internal class NonFiction : OurBook
    {
        public override int GetMaxBarrowDays()
        {
            return 14;
        }
    }


    internal class SafeBorrowService
    {
        public void Borrow(OurBook book)
        {
            int maxDays = book.GetMaxBarrowDays();
            Console.WriteLine($"{book.Title} can be borrowed for {maxDays} days.");
        }
    }


}
