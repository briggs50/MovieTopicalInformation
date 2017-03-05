using briggs50_MovieTopicalInformation.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace briggs50_MovieTopicalInformation
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["dataFilePath"] = HttpContext.Current.Server.MapPath("~/App_Data/Movie.xml");
        }

        protected void Session_Start()
        {
            Session["Movies"] = InitializeSeedData.GetAllMovies();
        }
    }
}
