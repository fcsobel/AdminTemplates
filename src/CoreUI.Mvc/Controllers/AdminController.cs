using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult Dashboard()
		{
			return View();
		}

		public ActionResult Colors()
		{
			return View();
		}

		public ActionResult Charts()
		{
			return View();
		}
	}
}