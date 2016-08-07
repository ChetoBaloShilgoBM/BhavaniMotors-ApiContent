using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApiContent.Startup))]
namespace ApiContent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
