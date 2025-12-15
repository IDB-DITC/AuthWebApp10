namespace AuthWebApplication.Model
{
  public class ReportModel
  {
    public string ReportTitle { get; set; } = string.Empty;
    public string ExportFormat { get; set; } = string.Empty;
    public string ReportPath { get; set; } = string.Empty;
    public string? ReportQuery { get; set; }
    public List<object> ReportData { get; set; } = new();
    public string ReportName { get; set; } = string.Empty ;
  }
}
