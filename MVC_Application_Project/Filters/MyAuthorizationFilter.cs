using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace MVC_Application_Project.Filters
{
    public class MyAuthorizationFilter : ActionFilterAttribute, IAuthorizationFilter
    {
        string RoleName = string.Empty;
       public  MyAuthorizationFilter(string pRoleName)
        {
            RoleName = pRoleName;
        }
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (HttpContext.Current.Session["email"] == null)
            {
                filterContext.Result = new RedirectResult("~/Home/About");

            }
            else {
                if (HttpContext.Current.Session["UserRole"].ToString() != RoleName)
                {
                    filterContext.Result = new RedirectResult("~/Error/AuthorizationError");
                }
                 

            }
            //throw new NotImplementedException();
        }
    }
}