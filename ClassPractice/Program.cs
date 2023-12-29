namespace ClassPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(1, "Alan Kay", DateTime.Now);
            order.DisplayOrder();

            // Same result as above
            OrderPrimary order2 = new(1, "Alan Kay", DateTime.Now);
            order2.DisplayOrder();

            // Use var keyword to instantiate an object
            var order3 = new OnlineOrder(2, "Alan Turing", DateTime.Now, "England");
            order3.DisplayOrder();
        }
    }
}
