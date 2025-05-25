public class ExportTXT : IExportFile
{
  public void ExportToFile(Order order)
  {
    Console.WriteLine($"Exporting order {order.Id} to TXT...");
  }
}