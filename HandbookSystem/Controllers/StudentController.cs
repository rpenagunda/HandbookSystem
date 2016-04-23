using System.Web.Mvc;
using HandbookSystem.Helper;

namespace HandbookSystem.Controllers
{
    [Authorize(Roles = "Student")]
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            // Person model
            var person = Query.PersonInfo();

            return View(person);
        }
    }
}