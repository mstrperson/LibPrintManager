using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrintManagerWebInterface.Startup))]
namespace PrintManagerWebInterface
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
