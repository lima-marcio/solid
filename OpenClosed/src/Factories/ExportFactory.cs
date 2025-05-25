public static class ExportFactory
{
  public static IExportFile GetExportMethod(string fileType)
  {
    return fileType.ToLower() switch
    {
      "txt" => new ExportTXT(),
      "pdf" => new ExportPDF(),
      "json" => new ExportJSON(),
      _ => throw new ArgumentException("Invalid file type specified.")
    };
  }
}