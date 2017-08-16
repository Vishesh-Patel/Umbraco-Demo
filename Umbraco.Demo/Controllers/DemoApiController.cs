using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Umbraco.Web.WebApi;

namespace Umbraco.Demo.Controllers
{
    public class DemoApiController : UmbracoAuthorizedApiController
    {
        public IHttpActionResult GetMemberDetails(int id)
        {
            return Ok(Members.GetById(id));
        }
    }
}