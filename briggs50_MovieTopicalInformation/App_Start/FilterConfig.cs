using System.Web;
using System.Web.Mvc;

namespace briggs50_MovieTopicalInformation
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
