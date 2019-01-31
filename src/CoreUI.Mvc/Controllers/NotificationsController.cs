using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminApp.Controllers
{
    public class NotificationsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult Alerts()
		{
			return View();
		}

		public ActionResult Badge()
		{
			return View();
		}

		public ActionResult Modals()
		{
			return View();
		}
	}
}