﻿using System.Web.Mvc;
using HandbookSystem.Helper;

namespace HandbookSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Person model
            var person = Query.PersonInfo();

            return View(person);
        }
    }
}