namespace ClassPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new(1, "Alan Kay", DateTime.Now);
            order.DisplayOrder();

            var order2 = new Order(2, "Ted Nelson", DateTime.Now.AddDays(1));
            order2.DisplayOrder();

            order2.CustomerName = "Douglas Engelbart";
            order2.DisplayOrder();
            Console.WriteLine(order2.OrderId);

            var order3 = new OrderPrimary(3, "Tim Berners-Lee", DateTime.Now.AddDays(2));
            order3.DisplayOrder();
        }
    }
}