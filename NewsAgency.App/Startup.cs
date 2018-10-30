using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewsAgency.App.Startup))]

namespace NewsAgency.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}