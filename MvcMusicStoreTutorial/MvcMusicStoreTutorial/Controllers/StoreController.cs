using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStoreTutorial.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public String Index()
        {
            return "Hello from Store.Index()";
        }

        // GET: /Store/Browse?genre=Dicso
        public String Browse(string genre)
        {
            String message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return message; 
        }

        // GET: /Store/Details/5
        public String Details(int id)
        {
            String message = "Store.Details, ID = " + id;
            return message; 
        }
    }
}