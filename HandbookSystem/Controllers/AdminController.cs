using System.Web.Mvc;
using HandbookSystem.Dal;
using HandbookSystem.Helper;

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

        // GET: Admin/Modules
        public ActionResult Modules()
        {
            return View();
        }

        // GET: Admin/Users
        public ActionResult Users()
        {
            // Person model
            var allUsers = Query.AllUsers();

            return View(allUsers);
        }

        // GET: Admin/EditUsers
        [HttpGet]
        public ActionResult EditUsers(int id)
        {
            // Person model
            var person = Query.PersonInfo(id);

            return View(person);
        }

        // POST: Lecturer/EditUsers/Id
        [HttpPost]
        public ActionResult EditUsers(Person person)
        {
            // Save changes to the user
            Query.EditUsers(person);

            return RedirectToAction("Users");
        }

        // GET: UserModules
        public ActionResult UserModules()
        {
            return View();
        }
    }
}