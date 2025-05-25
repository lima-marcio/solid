Console.Clear();
var order = new Order(1, "Alfred", DateTime.Now);
Console.WriteLine($"Order ID: {order.Id}");
var exportMethod = ExportFactory.GetExportMethod("pdf");
exportMethod.ExportToFile(order);