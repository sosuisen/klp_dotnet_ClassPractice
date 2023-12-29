namespace BookPractice
{
    internal class Book(string author, string title, int pages)
    {
        public string Author { get; set; } = author;
        public string Title { get; set; } = title;
        public int Pages { get; set; } = pages;

        public virtual void DisplayBook()
        {
            Console.WriteLine($"Author: {Author}, Title: {Title}, Pages: {Pages}");
        }
    }
}