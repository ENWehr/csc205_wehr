using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StalkerNet.Startup))]
namespace StalkerNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
