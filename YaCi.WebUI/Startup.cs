using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YaCi.WebUI.Startup))]
namespace YaCi.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
