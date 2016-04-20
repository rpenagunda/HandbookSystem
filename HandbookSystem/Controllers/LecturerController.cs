using System.Web.Mvc;
using HandbookSystem.Helper;

namespace HandbookSystem.Controllers
{
    public class LecturerController : Controller
    {
        // GET: Handbook
        public ActionResult Index()
        {
            // Person model
            var person = Query.PersonInfo();

            return View(person);
        }

        // GET: Handbook/List/Id
        public ActionResult List(string id)
        {
            // Person model
            var person = Query.PersonInfo();

            return View(person);
        }

        // GET: Handbook/Edit/Id
        public ActionResult Edit(string id)
        {
            // Person model
            var person = Query.PersonInfo();

            return View(person);
        }
    }
}