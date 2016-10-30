using System.Web;
using System.Web.Mvc;

namespace MVCMusicStore_Team8 {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
