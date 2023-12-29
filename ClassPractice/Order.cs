namespace ClassPractice
{
    internal class Order
    {
        private int orderId;
        private string customerName;
        private DateTime orderDate;

        public Order(int orderId, string customerName, DateTime dateTime)
        {
            this.orderId = orderId;
            this.customerName = customerName;
            this.orderDate = dateTime;
        }

        public void DisplayOrder()
        {
            Console.WriteLine($"Order ID: {orderId}, Customer: {customerName}, Date: {orderDate.ToShortDateString()}");
        }
    }
}