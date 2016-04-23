using System.Web.Mvc;
using System.Web.Security;
using HandbookSystem.Helper;
using HandbookSystem.Models;

namespace HandbookSystem.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/Login
        public ActionResult Login()
        {
            return View();
        }

        //
        // POST: /Account/Login
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                if (Query.IsLoginValid(model))
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError("", "The username or password provided is incorrect.");

            return View(model);
        }

        //
        // GET: /Account/LogOff
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Login", "Account");
        }
    }
}