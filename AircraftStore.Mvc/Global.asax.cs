using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AircraftStore.Dal.Context;
using AircraftStore.Dal.Data;
using AircraftStore.Mvc.Controllers;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AircraftStore.Mvc
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {

            //Add Admin Role
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new IdentityContext()));
            if (!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole { Name = "Admin" };
                roleManager.Create(role);

            }

            System.Data.Entity.Database.SetInitializer(new SampleData());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error(object sender, EventArgs e)
        {
           
            var routeData = new RouteData();

            routeData.Values.Add("action", "NotFound");

            routeData.Values.Add("controller", "Error");
           

            IController errorController = new ErrorController();
            errorController.Execute(new RequestContext(new HttpContextWrapper(Context), routeData));
        }
    }
}
