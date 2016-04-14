using System;
using System.Linq;
using System.Web.Mvc;
using HandbookSystem.Dal;

namespace HandbookSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int id = 1)
        {
            // Person model
            Person person;

            try
            {
                using(var db = new AppDbEntities())
                {
                    person = db.People.Single(x => x.PersonId == id);
                    ViewBag.Module = person.Modules;
                }
            }
            catch
            {
                // Error message
                throw new Exception();
            }

            return View(person);
        }
    }
}