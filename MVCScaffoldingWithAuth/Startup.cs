using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCScaffoldingWithAuth.Startup))]
namespace MVCScaffoldingWithAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
