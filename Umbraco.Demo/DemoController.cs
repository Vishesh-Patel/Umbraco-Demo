using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace Umbraco.Demo.App_Plugins.DemoPlugin
{

    // GET: Default 
    public class DemoController : UmbracoAuthorizedController
    {
        public ActionResult Index()
        {
            var model = Umbraco.TypedContentAtRoot().FirstOrDefault();
            return View("~/Views/Home.cshtml", model);
        }
    }
}