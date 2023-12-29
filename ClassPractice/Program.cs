namespace ClassPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2023, 12, 31);
            Console.WriteLine(date);
            date = date.AddDays(1);
            Console.WriteLine(date);
        }
    }
}
