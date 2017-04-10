using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(DesignTinderWeb.Startup))]

namespace DesignTinderWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}                    