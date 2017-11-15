using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private static IList<string> Messages = new List<string>();

        public ActionResult Index()
        {
            ViewBag.Messages = Messages;
            return View();
        }

        public void Add(string message)
        {
            Messages.Add(message);
        }

        public ActionResult Private()
        {
            return View();
        }
    }
}