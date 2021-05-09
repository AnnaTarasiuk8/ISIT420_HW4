using System.Web;
using System.Web.Mvc;

namespace ISIT420_HW4_Tarasiuk_Gurskaia
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
