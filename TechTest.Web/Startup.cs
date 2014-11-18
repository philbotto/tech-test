using System.Reflection;
using Microsoft.Owin;
using Ninject;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(TechTest.Web.Startup))]
namespace TechTest.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            
            app.UseNinjectMiddleware(CreateKernel);
            app.UseNinjectWebApi(config);
         }

        private static StandardKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            Bootstrap.Load(kernel);
            
            return kernel;
        }
    }
}
