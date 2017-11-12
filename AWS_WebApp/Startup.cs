using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AWS_WebApp.Startup))]
namespace AWS_WebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
