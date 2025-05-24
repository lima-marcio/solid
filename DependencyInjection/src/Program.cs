Console.Clear();
var order = new Order(1, "Alfred", 100.50m);
Console.WriteLine($"Order details: {order.OrderId}, {order.CustomerName}, {order.TotalAmount}");

// If you're using a debit card payment method
var paymentService1 = new PaymentService(new DebitCardPayment());
paymentService1.ProcessPayment(order.TotalAmount);

// If you're using a credit card payment method
var paymentService2 = new PaymentService(new CreditCardPayment());
paymentService2.ProcessPayment(order.TotalAmount);