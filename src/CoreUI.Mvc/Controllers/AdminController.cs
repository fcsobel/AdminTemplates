using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoreUI.Mvc.Controllers
{
    public class AdminController : Controller
	{
        public ActionResult Index()
        {
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Dashboard()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Colors()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Charts()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Typography()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Widgets()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}
	}
}