using System.Web.Mvc;
using HandbookSystem.Helper;

namespace HandbookSystem.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return RedirectToAction("Index", Query.GetRole(HttpContext.User.Identity.Name));
        }
    }
}