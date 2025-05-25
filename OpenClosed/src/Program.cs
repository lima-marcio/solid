Console.Clear();
var order = new Order(1, "Alfred", DateTime.Now);
Console.WriteLine($"Order ID: {order.OrderId}");
var exportOrder = new ExportOrder();
exportOrder.Export(order, "json");