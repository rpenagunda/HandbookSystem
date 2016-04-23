using System.Web.Mvc;
using HandbookSystem.Helper;
using HandbookSystem.Models;

namespace HandbookSystem.Controllers
{
    [Authorize]
    public class LecturerController : Controller
    {
        // GET: Lecturer
        public ActionResult Index()
        {
            // Person model
            var person = Query.PersonInfo();

            return View(person);
        }

        // GET: Lecturer/List/Id
        public ActionResult List()
        {
            // Person model
            var person = Query.PersonInfo();

            return View(person);
        }

        // GET: Lecturer/Edit/Id
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var module = Query.ModuleInfo(id);

            return View(module);
        }

        // POST: Lecturer/Edit/Id
        [HttpPost]
        public ActionResult Edit(ModuleInfo moduleInfo)
        {
            // Save changes to the handbook
            Query.EditHandbook(moduleInfo);

            return RedirectToAction("List");
        }

        // GET: Lecturer/Download
        public ActionResult Download(ModuleInfo moduleInfo)
        {
            // Person model
            var person = Query.PersonInfo();

            return View(person);
        }

        // GET: Lecturer/ViewAll
        public ActionResult ViewAll()
        {
            // Get all the modules
            var modulesList = Query.AllModules();

            return View(modulesList);
        }
    }
}