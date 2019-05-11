using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoreUI.Mvc.Controllers
{
    public class ButtonsController : Controller
	{
        public ActionResult Index()
        {
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Buttons()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Dropdowns()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}


		[ActionName("brand-buttons")]
		[Route("brand-buttons")]
		public ActionResult BrandButtons()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		[ActionName("button-group")]
		[Route("button-group")]
		public ActionResult ButtonGroup()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

	}
}