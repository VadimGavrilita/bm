using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using Interfases.BL;
using Ninject.Modules;

namespace DependencyResolver
{
    public class BusinessLayerModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBookManager>().To<BookWebManager>();
        }
    }
}
