using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using DependencyResolver;
using Interfases.BL;
using Interfases.DL;
using Ninject;
using Ninject.Modules;

namespace BS.App_Start
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private readonly StandardKernel _kernel;

        public NinjectControllerFactory()
        {
            _kernel = new StandardKernel();
            AddBindings();
        }

        private void AddBindings()
        {
            _kernel.Load(new INinjectModule[]{ new BusinessLayerModule() , new DataAccessModule() });
        }

        protected override IController GetControllerInstance(RequestContext requestContext, System.Type controllerType)
        {
            return controllerType == null ? null : (IController)_kernel.Get(controllerType);
        }
    }

}