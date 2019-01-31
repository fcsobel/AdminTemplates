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
			if (Request.IsAjaxRequest())
			{
				return PartialView();
			}
			else
			{
				return View();
			}
		}

		public ActionResult Alerts()
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

		public ActionResult Badge()
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

		public ActionResult Modals()
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