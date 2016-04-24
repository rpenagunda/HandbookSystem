using System.Web.Mvc;

namespace HandbookSystem.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        // GET: Modules
        public ActionResult Modules()
        {
            return View();
        }

        // GET: Users
        public ActionResult Users()
        {
            return View();
        }

        // GET: UserModules
        public ActionResult UserModules()
        {
            return View();
        }
    }
}