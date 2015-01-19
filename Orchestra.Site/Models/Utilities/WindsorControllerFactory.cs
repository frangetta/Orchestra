using System;
using System.Web.Mvc;
using System.Web.Routing;
using Castle.Windsor;

namespace Orchestra.Site.Models.Utilities
{
    public class WindsorControllerFactory : DefaultControllerFactory
    {
        private readonly IWindsorContainer windsorContainer;

        public WindsorControllerFactory(IWindsorContainer windsorContainer)
        {
            this.windsorContainer = windsorContainer;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return (IController)windsorContainer.Resolve(controllerType);
        }

        public override void ReleaseController(IController controller)
        {
            var disposable = controller as IDisposable;
            if (disposable != null)
            {
                disposable.Dispose();
            }
            windsorContainer.Release(controller);
        }
    }
}