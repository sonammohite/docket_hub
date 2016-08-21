using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Docket.Startup))]
namespace Docket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
