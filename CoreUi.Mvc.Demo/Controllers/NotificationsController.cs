using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoreUI.Mvc.Controllers
{
	public class NotificationsController : Controller
	{
		public ActionResult Index()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Alerts()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Badge()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Modals()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}
	}
}