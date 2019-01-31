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
			if (Request.IsAjaxRequest())
			{
				return PartialView();
			}
			else
			{
				return View();
			}
		}

		public ActionResult Dashboard()
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

		public ActionResult Colors()
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

		public ActionResult Charts()
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

		public ActionResult Typography()
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

		public ActionResult Widgets()
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