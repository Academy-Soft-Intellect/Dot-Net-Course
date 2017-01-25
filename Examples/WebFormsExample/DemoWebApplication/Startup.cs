using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoWebApplication.Startup))]
namespace DemoWebApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
