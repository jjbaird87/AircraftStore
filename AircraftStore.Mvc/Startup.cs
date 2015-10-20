using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AircraftStore.Mvc.Startup))]
namespace AircraftStore.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
