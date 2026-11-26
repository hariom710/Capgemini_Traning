using System;

namespace Problem4
{
    class PhotoBook
    {
        private int numPages;
        public PhotoBook()
        {
            numPages = 16;
        }
        public PhotoBook(int pages)
        {
            numPages = pages;
        }
        public int GetNumberPages()
        {
            return numPages;
        }
    }
    class BigPhotoBook : PhotoBook
    {
        public BigPhotoBook()
            : base(64)
        {
        }
    }
    class PhotoBookTest
    {
        public static void Run()
        {
            var defaultBook = new PhotoBook();
            Console.WriteLine($"Default photo book pages: {defaultBook.GetNumberPages()}");
            var book24 = new PhotoBook(24);
            Console.WriteLine($"Photo book with 24 pages: {book24.GetNumberPages()}");
            var big = new BigPhotoBook();
            Console.WriteLine($"Large photo book pages: {big.GetNumberPages()}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PhotoBookTest.Run();
        }
    }
}
