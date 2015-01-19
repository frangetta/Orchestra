using System.Web.Mvc;
using System.Web.Routing;
using Castle.Windsor;
using Orchestra.Site.Models.Utilities;

namespace Orchestra.Site
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            var windsorContainer = new WindsorContainer();
            ContainerConfig.RegisterInstallers(windsorContainer);
            DependencyResolver.SetResolver(new WindsorDependencyResolver(windsorContainer));
            ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(windsorContainer));
        }


    }
}
