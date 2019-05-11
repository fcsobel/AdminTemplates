using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoreUI.Mvc.Controllers
{
    public class IconsController : Controller
    {
        public ActionResult Index()
        {
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		[ActionName("coreui-icons")]
		[Route("coreui-icons")]
		public ActionResult CoreuiIcons()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		public ActionResult Flags()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		[ActionName("font-awesome")]
		[Route("font-awesome")]
		public ActionResult FontAwesome()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}

		[ActionName("simple-line-icons")]
		[Route("simple-line-icons")]
		public ActionResult SimpleLineIcons()
		{
			return Request.IsAjaxRequest() ? (ActionResult)PartialView() : View();
		}		
	}
}