using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(session3_DataMigrationAuth.Startup))]
namespace session3_DataMigrationAuth
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
