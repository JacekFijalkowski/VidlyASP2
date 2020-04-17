using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyASP2.Startup))]
namespace VidlyASP2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
