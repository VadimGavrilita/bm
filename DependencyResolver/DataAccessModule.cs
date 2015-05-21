using Interfases.DL;
using MOCK_Data_Layer;
using Ninject.Modules;

namespace DependencyResolver
{
    public class DataAccessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBookRepository>().To<MockBookRepository>();
        }
    }
}
