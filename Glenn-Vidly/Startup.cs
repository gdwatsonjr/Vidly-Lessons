using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Glenn_Vidly.Startup))]
namespace Glenn_Vidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
