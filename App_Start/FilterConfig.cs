using System.Web;
using System.Web.Mvc;

namespace Centric_Consulting_Project_Team_9
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
