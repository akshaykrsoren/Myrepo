using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Application_Project.Repository;



namespace MVC_Application_Project.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

      
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CreateEmployee()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult CreateEmployee(tblEmployee obj)
        {
            using (testdbEntities objentity = new testdbEntities())
            {
                //tblEmployee objemp = new tblEmployee();
                //objemp.Name = obj.Name;
                //objemp.Email = obj.Email;
                //objemp.Phone = obj.Phone;
                //objemp.Salary = obj.Salary;
                //objemp.tblcountry.countryid =(Int32) obj.CountryId;
                //objemp.tblRoleMaster.RoleId = (Int32)obj.RoleTypeId;
                //objemp.Name = obj.Name;
                

            }

            return View();
        }

        public ActionResult GetEmployee()
        {
            List<tblEmployee> lstemp = new List<tblEmployee>();
            using (testdbEntities objentity= new testdbEntities())
            {
               
                lstemp = objentity.tblEmployees.ToList();

            }
                return View(lstemp);
        }
    }
}