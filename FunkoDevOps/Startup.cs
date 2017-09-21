using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FunkoDevOps.Startup))]
namespace FunkoDevOps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
