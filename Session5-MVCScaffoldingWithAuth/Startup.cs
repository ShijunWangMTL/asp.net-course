using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Session5_MVCScaffoldingWithAuth.Startup))]
namespace Session5_MVCScaffoldingWithAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
