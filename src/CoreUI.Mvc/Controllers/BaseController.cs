using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminApp.Controllers
{
    public class BaseController : Controller
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

		public ActionResult Breadcrumb()
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

		public ActionResult Cards()
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

		public ActionResult Carousel()
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

		public ActionResult Forms()
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

		public ActionResult Jumbotron()
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

		[ActionName("list-group")]
		[Route("list-group")]
		public ActionResult ListGroup()
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

		public ActionResult Navs()
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

		public ActionResult Pagination()
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

		public ActionResult Popovers()
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

		public ActionResult Progress()
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

		public ActionResult Scrollspy()
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

		public ActionResult Switches()
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

		public ActionResult Tables()
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

		public ActionResult Tabs()
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

		public ActionResult Tooltips()
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