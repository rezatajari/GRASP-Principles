using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASP_Principles
{
    namespace PureFabrication
    {
        class PureFabrication
        {
        }

        // Pure Fabrication failed
        class User
        {
            public string Email { get; set; }
        }
        class Book
        {
            public string Title { get; set; }

            // Domain logic + side effect mixed
            public void Barrow(User user)
            {
                // logic for marking as borrowed...
                SendEmail(user.Email, $"You borrowed {Title}");
            }

            void SendEmail(string to, string body)
            {
                // SMTP or 3rd party code
            }
        }



        // Pure Fabrication passed
        class Controller
        {

            void BarrowBook(User user, Book book)
            {
                book.Barrow(user);
                NotificationService.SendEmail(user.Email, $"You borrowed {book.Title}");
            }

        }
        static class NotificationService
        {
            public static void SendEmail(string to, string body)
            {
                // SMTP or 3rd party code
            }
        }
    }
}
