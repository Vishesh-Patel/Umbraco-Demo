using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Umbraco.Core;

namespace Umbraco.Demo
{
public class SiteApplicationEventHandler : ApplicationEventHandler
{
    protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
    {
        RouteTable.Routes.MapRoute(
        name: "cats",
        url:  "umbraco/backoffice/{controller}/{action}/{id}",
        defaults: new
        {
            controller = "Demo",
            action = "Index",
            id = UrlParameter.Optional
        });
    }
}
}