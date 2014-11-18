using Ninject;

namespace TechTest.Web
{
    public static class Bootstrap
    {
        public static void Load(IKernel kernel)
        {
            Service.Bootstrap.Load(kernel);
        }
    }
}
