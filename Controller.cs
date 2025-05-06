using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASP_Principles
{
    internal class Controller
    {
    }

    // Its can passed controller as GRASP but coupling is not passed
    internal class BarrowController
    {
        // Its example is only for showcase of controller, but its method is wronged as coupling principle because we depend on object instead of interface
        public void Borrow(Book book, int userId)
        {
            if (book.IsAvailable())
            {
                book.Barrow();
            }
            else
            {
                Console.WriteLine("Book is not available for borrowing.");
            }

            // Logic to associate the book with the user
        }
    }

    // Its can passed controller as GRASP and also coupling is passed
    internal interface ILibraryService
    {
        void BorrowBook(Guid userId, Guid bookId);
    }
    internal class BorrowBookController
    {
        private readonly ILibraryService _libraryService;

        public BorrowBookController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        public void Borrow(Guid userId, Guid bookId)
        {
            _libraryService.BorrowBook(userId, bookId);
        }
    }

}
