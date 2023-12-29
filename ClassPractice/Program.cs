namespace BookPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Donald E. Knuth", "Literate Programming", 384);
            book.DisplayBook();

            var book2 = new Book("Cixin Liu", "The Three-Body Problem", 400);
            book2.DisplayBook();
        }
    }
}