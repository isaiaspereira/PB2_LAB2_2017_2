using System.Web;
using System.Web.Mvc;

namespace WebAppProva2blab2Isaias_Pereira
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
