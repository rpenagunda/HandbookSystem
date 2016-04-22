using System.IO;
using System.Web;
using System.Web.Mvc;
using HandbookSystem.Helper;
using SelectPdf;

namespace HandbookSystem.Controllers
{
    public class DownloadController : Controller
    {
        // GET: Download
        public ActionResult Index()
        {
            return View();
        }

        // Get the view template for printing handbook
        public ActionResult HandbookView(int id)
        {
            // Get the module info for the given ID
            var module = Query.ModuleInfo(id);
            return View(module);
        }

        // Method to call the pdf generation package (SelectPdf)
        public ActionResult HandbookPdf(int id)
        {
            // Get the module info for the given ID
            var module = Query.ModuleInfo(id);

            // instantiate a html to pdf converter object
            GlobalProperties.HtmlEngineFullPath = Server.MapPath(VirtualPathUtility.ToAbsolute("~/Content/Select.Html.dep"));
            var converter = new HtmlToPdf();
            converter.Options.MarginTop = 30;
            converter.Options.MarginBottom = 30;
            converter.Options.MarginLeft = 20;
            converter.Options.MarginRight = 20;

            // create a new pdf document converting an url
            var url = Url.Action("HandbookView", "Download", new { id = module.ModuleCode }, Request.Url?.Scheme);
            var doc = converter.ConvertUrl(url);

            // save pdf document
            var filestream = new MemoryStream();
            doc.Save(filestream);
            doc.Close();

            // flush stream
            filestream.Flush();
            filestream.Position = 0;

            return File(filestream, "application/pdf", $"{module.ModuleTitle}.pdf");
        }
    }
}