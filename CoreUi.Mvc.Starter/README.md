﻿

- CoreUi.Mvc.Starter 
  - Log
    + Add New Project: 
      + `ASP.Net Web Application (.NET Framework)` 
        + `CoreUi.Mvc.Starter`
        + Options: `Empty with Mvc & Web.Api`                
    + Change NapeSpace: `CoreUi.Mvc`
    + Add Package: `MvcSiteMapProvider.MVC5`
    + Add controllers:
      + `HomeController`
    + Add Views:
      + `/Home`
        + `/Index.cshtml`
        + `/About.cshtml`
        + `/SiteMap.cshtml`
      + `/Shared`
        + `/DisplayTemplates`
          + `/CoreUISiteMapHelperModel.cshtml`
          + `/CoreUISiteMapNodeModel.cshtml`
          + `/CoreUISiteMapNodeModelList.cshtml`
          + `/CoreUISiteMapPathHelperModel.cshtml`
        + `/Layouts`
          + `/CoreUI`
            + `/_AppHeader.cshtml`
            + `/_AsideMenu.cshtml`
            + `/_BreadCrumb.cshtml`
            + `/_Footer.cshtml`
            + `/_Layout.cshtml`
            + `/_SidebarNav.cshtml`        
    + Add Models:
      + `SiteMapNodeModelExtensions.cs`