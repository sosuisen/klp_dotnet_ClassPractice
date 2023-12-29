namespace ClassPractice
{
    internal class OnlineOrder(int orderId, string customerName, DateTime dateTime, string deliveryAddress) : OrderPrimary(orderId, customerName, dateTime)
    {
        public string DeliveryAddress { get; set; } = deliveryAddress;

        public override void DisplayOrder()
        {
            Console.WriteLine($"Order ID: {OrderId}, Customer: {CustomerName}, Date: {OrderDate.ToShortDateString()}, Delivery Address: {DeliveryAddress}");
        }
    }
}