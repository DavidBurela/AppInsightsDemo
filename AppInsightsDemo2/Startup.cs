using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppInsightsDemo2.Startup))]
namespace AppInsightsDemo2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
