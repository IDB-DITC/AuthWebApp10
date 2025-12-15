using AuthWebApplication.Model;
using FastReport;
using FastReport.Data;
using FastReport.Export.PdfSimple;
using FastReport.Web;
using Microsoft.AspNetCore.Mvc;

namespace AuthWebApplication.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class WebReportController() : ControllerBase
  {
    //public async Task< IActionResult> Index()//ReportModel data
    //{
    //  string ReportName = "author report";




    // WebReport webReport = new WebReport();


    //  AuthorList authorReport = new();

    //  authorReport.RegisterData(db.Authors.ToList(), ReportName);

    //  authorReport.GetDataSource(ReportName).Enabled = true;
    //  if(await authorReport.PrepareAsync())
    //  {

    //    webReport.Report = authorReport;
    //  }
    //}


    [HttpGet("{id:int?}")]
    public ActionResult<string?> Get(int id = 0)
    {
      try
      {
        //WebReport webReport = new WebReport();

        //webReport.Report.Load(_webHost.ContentRootPath + "\\Reports\\ProductInfo.frx");


        AuthorList authorList = new AuthorList();




        //MsSqlDataConnection sqlConnection = new MsSqlDataConnection();


        //sqlConnection.ConnectionString = config.GetConnectionString("DefaultConnection");


        //webReport.Report.SetParameterValue("CONN", sqlConnection.ConnectionString);


        //authorList.SetParameterValue("CONN", sqlConnection.ConnectionString);


        //webReport.Report.SetParameterValue("CatID", id);
        //webReport.Report.Prepare();

        authorList.Prepare();


        PDFSimpleExport export = new PDFSimpleExport();
        string pdf;
        byte[] pdfBytes;
        MemoryStream ms = new MemoryStream();

        //webReport.Report.Export(export, ms);
        authorList.Export(export, ms);
        ms.Position = 0;
        pdfBytes = ms.ToArray();

        pdf = "data:application/pdf;base64," + Convert.ToBase64String(pdfBytes);
        return Ok(pdf);
      }
      catch (Exception ex)
      {

        return BadRequest(ex);
      }
    }

    
  }
}
