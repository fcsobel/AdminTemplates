using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminApp.Controllers
{
    public class IconsController : Controller
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

		[ActionName("coreui-icons")]
		[Route("coreui-icons")]
		public ActionResult CoreuiIcons()
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

		public ActionResult Flags()
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

		[ActionName("font-awesome")]
		[Route("font-awesome")]
		public ActionResult FontAwesome()
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

		[ActionName("simple-line-icons")]
		[Route("simple-line-icons")]
		public ActionResult SimpleLineIcons()
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