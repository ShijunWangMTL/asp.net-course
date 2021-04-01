using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Session7_VideoRental.Startup))]
namespace Session7_VideoRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
