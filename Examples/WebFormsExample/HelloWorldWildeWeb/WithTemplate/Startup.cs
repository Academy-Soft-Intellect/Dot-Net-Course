using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WithTemplate.Startup))]
namespace WithTemplate
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
