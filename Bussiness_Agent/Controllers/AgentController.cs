using Business_Agent.Core.Entities;
using Business_Agent.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bussiness_Agent.Controllers
{
    public class AgentController : Controller
    {
        private readonly IAgentService _service;

        public AgentController(IAgentService service)
        {
            this._service = service;
        }
        [HttpGet]
        public ActionResult CreateAgent()
        {
            return View("~/Views/Home/Index.cshtml");
        }
        [HttpPost]
        public ActionResult CreateAgent(BusinessEntities CreateAgent)
        {
            if (_service.Add(CreateAgent))
            {
                return View("~/Views/Home/Index.cshtml");
            }
                return View();
        }
    }
}