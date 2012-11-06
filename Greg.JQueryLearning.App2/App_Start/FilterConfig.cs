using System.Web;
using System.Web.Mvc;

namespace Greg.JQueryLearning.App2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}