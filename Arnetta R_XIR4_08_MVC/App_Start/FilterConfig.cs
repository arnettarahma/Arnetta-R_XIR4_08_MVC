using System.Web;
using System.Web.Mvc;

namespace Arnetta_R_XIR4_08_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
