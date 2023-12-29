namespace ClassPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(1, "Alan Kay", DateTime.Now);
            order.DisplayOrder();
        }
    }
}