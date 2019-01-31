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
            return View();
        }

		[ActionName("coreui-icons")]
		[Route("coreui-icons")]
		public ActionResult CoreuiIcons()
		{
			return View();
		}

		public ActionResult Flags()
		{
			return View();
		}

		[ActionName("font-awesome")]
		[Route("font-awesome")]
		public ActionResult FontAwesome()
		{
			return View();
		}

		[ActionName("simple-line-icons")]
		[Route("simple-line-icons")]
		public ActionResult SimpleLineIcons()
		{
			return View();
		}		
	}
}