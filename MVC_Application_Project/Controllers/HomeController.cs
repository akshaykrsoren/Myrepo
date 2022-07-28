using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Application_Project.Filters;

using MVC_Application_Project.Models;

namespace MVC_Application_Project.Controllers
{
    public class HomeController : Controller
    { 
        public ActionResult Index()
        {

            return RedirectToAction("CreateEmployee", "Employee");
        }
      
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

       
        public ActionResult Login()
        {
            Dictionary<string, string> userData = new Dictionary<string, string>();
            LoginModel obj = new Models.LoginModel();
             userData = obj.Login();
            if (!String.IsNullOrEmpty(userData["UserName"]))
            {
                Session["email"] = userData["UserName"];
                Session["UserRole"] = userData["UserRole"];
                return RedirectToAction("EmployeeProfile", "Account");
            }
            else {
                return RedirectToAction("LoginError","Error");
            }
           
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}