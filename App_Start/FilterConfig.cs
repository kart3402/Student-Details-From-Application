using System.Web;
using System.Web.Mvc;

namespace Kartavya_Guntewar_Interview_Assignment
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
