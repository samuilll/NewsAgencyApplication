using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using NewsAgency.App.App_Start;

namespace NewsAgency.App
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
           // AutoMapperInitialize.InitializeMapper();
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            // Exception lastError = Server.GetLastError();

            Response.Redirect("~/Error");
           // Context.ClearError();
        }
    }
}
