namespace BookPractice
{
    internal class ElectronicBook(string author, string title, int pages, double size) : Book(author, title, pages)
    {
        public double Size { get; set; } = size;

        public override void DisplayBook()
        {
            Console.WriteLine($"Author: {Author}, Title: {Title}, Pages: {Pages}, Size: {Size} Mbytes");
        }
    }
}
