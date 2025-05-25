public class ExportOrder
{
  public void Export(Order order, string format)
  {
    switch (format.ToUpper())
    {
      case "TXT":
        new ExportTXT().ExportToTXT(order);
        break;
      case "JSON":
        new ExportJSON().ExportToJSON(order);
        break;
      case "PDF":
        new ExportPDF().ExportToPDF(order);
        break;
      default:
        throw new ArgumentException("Invalid export format");
    }
  }
}