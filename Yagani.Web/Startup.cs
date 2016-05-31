using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Yagani.Web.Startup))]
namespace Yagani.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
