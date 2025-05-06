using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASP_Principles
{
    namespace Indirection
    {
        internal class Indirection
        {
        }


        // Indirection failed
        internal class Book { }

        class BorrowService
        {
            public void Borrow(string bookId)
            {
                var book = new Book(); // or directly from DB
                                       // operate on book directly...
            }
        }


        // Indirection passed
        interface IBookRepository
        {
            Book GetById(string bookId);
        }

        class SafeBorrowService
        {
            private readonly IBookRepository _bookRepository;

            public SafeBorrowService(IBookRepository bookRepository)
            {
                _bookRepository = bookRepository;
            }

            public void Borrow(string bookId)
            {
                var book = _bookRepository.GetById(bookId);
                // logic...
            }
        }

    }

}
