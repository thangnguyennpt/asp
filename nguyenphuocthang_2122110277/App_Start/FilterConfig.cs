using System.Web;
using System.Web.Mvc;

namespace nguyenphuocthang_2122110277
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
