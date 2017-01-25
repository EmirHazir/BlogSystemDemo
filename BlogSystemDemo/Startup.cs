using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogSystemDemo.Startup))]
namespace BlogSystemDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
