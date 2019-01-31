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
            return View();
        }

		public ActionResult Breadcrumb()
		{
			return View();
		}

		public ActionResult Cards()
		{
			return View();
		}

		public ActionResult Carousel()
		{
			return View();
		}

		public ActionResult Forms()
		{
			return View();
		}

		public ActionResult Jumbotron()
		{
			return View();
		}

		[ActionName("list-group")]
		[Route("list-group")]
		public ActionResult ListGroup()
		{
			return View();
		}

		public ActionResult Navs()
		{
			return View();
		}

		public ActionResult Pagination()
		{
			return View();
		}

		public ActionResult Popovers()
		{
			return View();
		}

		public ActionResult Progress()
		{
			return View();
		}

		public ActionResult Scrollspy()
		{
			return View();
		}

		public ActionResult Switches()
		{
			return View();
		}

		public ActionResult Tables()
		{
			return View();
		}

		public ActionResult Tabs()
		{
			return View();
		}

		public ActionResult Tooltips()
		{
			return View();
		}
	}
}