using System.Web;
using System.Web.Mvc;

namespace DuongNguyenSongPhi_2011062999
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
