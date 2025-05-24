Console.Clear();
var order = new Order(1, "Alfred", 100.50m);
Console.WriteLine($"Order details: {order.OrderId}, {order.CustomerName}, {order.TotalAmount}");
var paymentService = new PaymentService();
paymentService.ProcessPayment(order.TotalAmount);
