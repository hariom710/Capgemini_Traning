using System;
namespace DAY2
{
    internal class Book
    {
        private bool _available = true;

        public void IssueBook()
        {
            if (_available)
                _available = false;
            else
                Console.WriteLine("Book not available.");
        }

        public void ReturnBook()
        {
            _available = true;
        }

        public bool IsAvailable()
        {
            return _available;
        }
    }
}