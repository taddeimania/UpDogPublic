using System.Web;
using System.Web.Mvc;
using UpDog.Handlers;

namespace UpDog
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CustomErrorHandlerAttribute());
        }
    }
}