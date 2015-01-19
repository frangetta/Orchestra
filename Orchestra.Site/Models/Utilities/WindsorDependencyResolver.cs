using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Castle.Windsor;

namespace Orchestra.Site.Models.Utilities
{
    public class WindsorDependencyResolver : IDependencyResolver
    {
        private readonly IWindsorContainer windsorContainer;

        public WindsorDependencyResolver(IWindsorContainer windsorContainer)
        {
            this.windsorContainer = windsorContainer;
        }

        public object GetService(Type serviceType)
        {
            return windsorContainer.Kernel.HasComponent(serviceType)
                ? windsorContainer.Resolve(serviceType)
                : null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return windsorContainer.ResolveAll(serviceType).Cast<object>();
        }
    }
}