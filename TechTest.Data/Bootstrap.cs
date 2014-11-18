using Ninject;
using Ninject.Web.Common;
using TechTest.Data.Contracts;
using TechTest.Domain.Entities;

namespace TechTest.Data
{
    public static class Bootstrap
    {
        public static void Load(IKernel kernel)
        {
            kernel.Bind<ITechTestEntities>().To<TechTestEntities>().InRequestScope();
        }
    }
}
