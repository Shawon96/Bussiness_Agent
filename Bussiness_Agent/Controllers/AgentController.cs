using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bussiness_Agent.Controllers
{
    public class AgentController : Controller
    {
        [HttpGet]
        public ActionResult CreateAgent()
        {
            return View("~/Views/Home/Index.cshtml");
        }
    }
}