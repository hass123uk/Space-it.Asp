using System;
using System.Configuration;
using System.IO;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Space_it.Core.NHibernate_Data;

namespace Space_it.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
            NHibernateSessionManager.ConnectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            NHibernateSessionManager.CloseSession();
        }
    }
}
