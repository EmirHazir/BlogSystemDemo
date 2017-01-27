using Microsoft.Owin;
using Ninject;
using Owin;
using System.Reflection;

[assembly: OwinStartupAttribute(typeof(BlogSystemDemo.Startup))]
namespace BlogSystemDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

        private static StandardKernel CreateKarnel()
        {
            var karnel = new StandardKernel();
            karnel.Load(Assembly.GetExecutingAssembly());
            return karnel;
        }
    }
}
