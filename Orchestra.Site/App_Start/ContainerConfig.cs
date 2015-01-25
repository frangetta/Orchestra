using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Orchestra.DataLayer;
using Orchestra.Site.Controllers;
using Orchestra.Site.Models.Layout;

namespace Orchestra.Site
{
    public class ContainerConfig
    {
        public static void RegisterInstallers(IWindsorContainer windsorContainer)
        {
            var siteAssembly = typeof (HomeController).Assembly;

            windsorContainer.Register(new IRegistration[]
            {
                Component.For<OrchestraDatabaseContext>().LifeStyle.PerWebRequest,

                Classes
                    .FromAssembly(siteAssembly)
                    .Where(type => type.Name.EndsWith("Controller"))
                    .Configure(c => c.LifestyleTransient()),

                Classes
                    .FromAssembly(siteAssembly)
                    .Where(type => type.Name.EndsWith("ViewModelBuilder") || type.Name.EndsWith("Validator") || type.Name.EndsWith("Repository"))
                    .Configure(c => c.LifestylePerWebRequest())
                    .WithService.DefaultInterfaces(),

                Component.For<ILayoutModelBuilder>().ImplementedBy<LayoutModelBuilder>().LifeStyle.PerWebRequest,
                Component.For<IDatabaseContext>().ImplementedBy<DatabaseContext>().LifeStyle.PerWebRequest,
            });
        }
    }
}