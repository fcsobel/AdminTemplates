using System;
using System.Collections.Generic;
using System.Linq;

namespace MvcSiteMapProvider.Web.Html.Models
{
	public static class SiteMapNodeModelExtensions
	{
		public static string Icon(this SiteMapNodeModel node, bool inherit = true) { return node.GetAttribute("icon", inherit); }
		public static bool Visible(this SiteMapNodeModel node, bool inherit=false) { return node.GetAttribute("visible", inherit) != "false"; } // default = true
		public static string GetAttribute(this SiteMapNodeModel node, string name, bool inherit = true)
		{
			// look for parent with matching value
			if (inherit) { while (node != null && !node.Attributes.Any(x => x.Key == name)) { node = node.Parent; } }
			
			// return value from node
			if (node != null) { return node.Attributes.FirstOrDefault(x => x.Key == name).Value as string; }

			return null;
		}
	}
}