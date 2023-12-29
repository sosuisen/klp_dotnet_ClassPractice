namespace ClassPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(1, "Alan Kay", DateTime.Now);
            order.DisplayOrder();

            Order order2 = new Order(2, "Ted Nelson", DateTime.Now.AddDays(1));
            order2.DisplayOrder();
        }
    }
}