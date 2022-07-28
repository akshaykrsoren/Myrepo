using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace MVC_Application_Project.Filters
{
    public class MyAuthenticationFilter : ActionFilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {

            if (HttpContext.Current.Session["email"] == null)
            {
                filterContext.Result = new RedirectResult("~/Error/LoginError");
            }
            
        }
    

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            //throw new NotImplementedException();
        }
    }

        
     
}