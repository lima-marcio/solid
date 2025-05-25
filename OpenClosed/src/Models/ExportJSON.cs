public class ExportJSON : IExportFile
{
  public void ExportToFile(Order order)
  {
    Console.WriteLine($"Exporting order {order.Id} to JSON...");
  }
}