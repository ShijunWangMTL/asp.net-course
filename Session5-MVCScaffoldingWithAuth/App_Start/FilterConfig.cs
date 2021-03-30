using System.Web;
using System.Web.Mvc;

namespace Session5_MVCScaffoldingWithAuth
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
