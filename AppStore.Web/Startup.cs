using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppStore.Web.Startup))]
namespace AppStore.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
