using System.Web;
using System.Web.Mvc;

namespace LVH_ASPNET_Lab05
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
