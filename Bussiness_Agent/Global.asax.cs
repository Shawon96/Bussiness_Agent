using Business_Agent.Core.Service;
using Business_Agent.Infrastructure;
using Business_Agent.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;
using Unity.AspNet.Mvc;

namespace Bussiness_Agent
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            IUnityContainer container = new UnityContainer();
            container.RegisterType<DbContext, BussinessClientDbContext>(); 
            container.RegisterType<IAgentService, AgentService>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
