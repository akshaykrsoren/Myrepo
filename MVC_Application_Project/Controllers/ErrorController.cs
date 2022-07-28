using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Application_Project.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LoginError()
        {
            return View();
        }
        public ActionResult AuthorizationError()
        {
            return View();
        }
    }
}