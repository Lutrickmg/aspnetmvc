using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspnetmvc.Startup))]
namespace aspnetmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
