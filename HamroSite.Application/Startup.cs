using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HamroSite.Application.Startup))]
namespace HamroSite.Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
