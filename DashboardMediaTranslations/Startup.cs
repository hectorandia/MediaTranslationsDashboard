using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DashboardMediaTranslations.Startup))]
namespace DashboardMediaTranslations
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
