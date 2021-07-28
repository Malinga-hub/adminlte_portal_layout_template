using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace portal_layout_template.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        public ActionResult Datatable()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AccountProfile()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AccountChangePassword()
        {
            return View();
        }
    }
}