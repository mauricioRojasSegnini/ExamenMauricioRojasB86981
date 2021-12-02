using System.Web;
using System.Web.Mvc;

namespace RojasB86981ExamenInge
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
