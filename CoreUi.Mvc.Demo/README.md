

- CoreUi.Mvc.Starter 
  - Log
    + Add New Project: `ASP.Net Web Application (.NET Framework)`
      + `CoreUi.Mvc.Demo`
        + Options: `Empty with Mvc & Web.Api`       
    + Change NameSpace: `CoreUi.Mvc`
    + Add Package: `MvcSiteMapProvider.MVC5`
      + Delete: `*.ascx` files under `/views/shared/DisplayTemplates`
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