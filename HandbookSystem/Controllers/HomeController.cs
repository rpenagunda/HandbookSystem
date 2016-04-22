using System.Web.Mvc;

namespace HandbookSystem.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return RedirectToAction("Index","Lecturer");
        }
    }
}