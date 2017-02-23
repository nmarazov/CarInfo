using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarInfoWebClient.Startup))]
namespace CarInfoWebClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
