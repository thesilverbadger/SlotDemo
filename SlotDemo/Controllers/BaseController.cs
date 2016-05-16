using SlotDemo.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SlotDemo.Controllers
{
    public class BaseController : Controller
    {

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            ViewBag.Version = Settings.Version;

            base.OnActionExecuted(filterContext);
        }
    }
}