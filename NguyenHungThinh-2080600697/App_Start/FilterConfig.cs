using System.Web;
using System.Web.Mvc;

namespace NguyenHungThinh_2080600697
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
