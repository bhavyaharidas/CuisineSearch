using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CuisineSearch.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        public ActionResult Search(String name)
        {
            string msg = Server.HtmlEncode(name);
            return Json(new { Message = msg, name = "Bhavya" }, JsonRequestBehavior.AllowGet);
        }
    }
}