using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoreUI.Mvc.Controllers
{
    public class BaseController : Controller
	{
        public ActionResult Index()
        {
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Breadcrumb()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Collapse()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Cards()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Carousel()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Forms()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Jumbotron()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();			
		}

		[ActionName("list-group")]
		[Route("list-group")]
		public ActionResult ListGroup()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Navs()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Pagination()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Popovers()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Progress()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Scrollspy()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Switches()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();			
		}

		public ActionResult Tables()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Tabs()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Tooltips()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}
	}
}