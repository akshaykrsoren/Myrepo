using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
 
[assembly: OwinStartup(typeof(MVC_Application_Project.Startup1))]

namespace MVC_Application_Project
{
    public class Startup1
    {
        public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            OAuthOptions = new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/OAuth/Token"),
                //Provider = new testc(),
                AuthorizeEndpointPath = new PathString("/api/Account/ExternalLogin"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(5),
                AllowInsecureHttp = true
            };
            app.Run(context=> {
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello world"); ;
            });
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
