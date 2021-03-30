using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Session5_MVCScaffolding.Startup))]
namespace Session5_MVCScaffolding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
