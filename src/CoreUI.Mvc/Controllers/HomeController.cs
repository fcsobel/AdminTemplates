using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
			if (Request.IsAjaxRequest())
			{
				return PartialView();
			}
			else
			{
				return View();
			}
		}

		// GET: Home
		public ActionResult About()
		{
			if (Request.IsAjaxRequest())
			{
				return PartialView();
			}
			else
			{
				return View();
			}
		}

		// GET: Home
		public ActionResult SiteMap()
		{
			if (Request.IsAjaxRequest())
			{
				return PartialView();
			}
			else
			{
				return View();
			}
		}
	}
}