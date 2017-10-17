using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Buchies_Web.Startup))]
namespace Buchies_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
