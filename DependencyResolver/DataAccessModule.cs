using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ado.net_BL;
using BL;
using Interfases.BL;
using Interfases.DL;
using Ninject.Modules;

namespace DependencyResolver
{
    public class DataAccessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBookRepository>().To<AdoBookRepository>();
        }
    }
}
