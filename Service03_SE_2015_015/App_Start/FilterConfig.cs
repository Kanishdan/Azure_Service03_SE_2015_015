using System.Web;
using System.Web.Mvc;

namespace Service03_SE_2015_015
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
