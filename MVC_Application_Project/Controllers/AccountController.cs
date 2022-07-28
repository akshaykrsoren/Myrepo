using MVC_Application_Project.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Application_Project.Controllers
{
    public class AccountController : Controller
    {
        // GET: Acount
        public ActionResult Index()
        {
            return View();
        }
        [MyAuthenticationFilter]
        [MyAuthorizationFilter("1")]
        public ActionResult EmployeeProfile()
        {
            return View();
        }
    }
}