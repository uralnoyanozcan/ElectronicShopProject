using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.Cookies;
using System.Web.Security;
using Microsoft.AspNet.Identity;

[assembly: OwinStartup(typeof(WebApplication1.App_Code.Startup1))]

namespace WebApplication1.App_Code
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Pages/Account/Login.aspx")
            });
        }
    }
}
