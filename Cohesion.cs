using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASP_Principles
{
    internal class Cohesion
    {
    }

    // Low Cohesion
    internal class MagazineWithoutCohesion
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public bool IsBorrowed { get; private set; }

        public bool IsAvailable() => !IsBorrowed;

        // 🚩 Suspicious additions
        public string UserEmail { get; private set; }

        public bool Login(string email, string password)
        {
            // fake auth logic
            return true;
        }
    }

    // High Cohesion
    internal class MagazineCohesion
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public bool IsBorrowed { get; private set; }

        public bool IsAvailable() => !IsBorrowed;

        public void Barrow() => IsBorrowed = true;
        public void Return() => IsBorrowed = false;
    }

}
