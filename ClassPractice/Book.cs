namespace BookPractice
{
    internal class Book
    {
        private string author;
        private string title;
        private int pages;

        public virtual void DisplayBook()
        {
            Console.WriteLine($"Author: {author}, Title: {title}, Pages: {pages}");
        }

        public Book(string author, string title, int pages)
        {
            this.author = author;
            this.title = title;
            this.pages = pages;
        }
    }
}