namespace ClassPractice
{
    internal class Order
    {
        private int OrderId;
        private string CustomerName;
        private DateTime OrderDate;

        public Order(int orderId, string customerName, DateTime dateTime)
        {
            OrderId = orderId;
            CustomerName = customerName;
            OrderDate = dateTime;
        }

        public void DisplayOrder()
        {
            Console.WriteLine($"Order ID: {OrderId}, Customer: {CustomerName}, Date: {OrderDate.ToShortDateString()}");
        }
    }
}