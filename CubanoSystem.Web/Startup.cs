using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CubanoSystem.Web.Startup))]
namespace CubanoSystem.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
