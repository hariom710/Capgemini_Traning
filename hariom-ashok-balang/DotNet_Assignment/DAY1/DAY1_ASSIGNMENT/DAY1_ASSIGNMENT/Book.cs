using System;

namespace DAY1_ASSIGNMENT
{
    internal class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; } = true;

        public void IssueBook()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"Book '{Title}' issued successfully.");
            }
            else
            {
                Console.WriteLine($"Book '{Title}' is currently unavailable.");
            }
        }

        public void ReturnBook()
        {
            if (!IsAvailable)
            {
                IsAvailable = true;
                Console.WriteLine($"Book '{Title}' returned successfully.");
            }
            else
            {
                Console.WriteLine($"Book '{Title}' was already available.");
            }
        }
    }
}
