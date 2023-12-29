namespace BookPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Cixin Liu, Ken Liu", "The Three-Body Problem", 400);
            book.DisplayBook();

            var book2 = new ElectronicBook("Cixin Liu, Ken Liu", "The Three-Body Problem", 400, 2.9);
            book2.DisplayBook();
        }
    }
}