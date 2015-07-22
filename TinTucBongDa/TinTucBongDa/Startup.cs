using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TinTucBongDa.Startup))]
namespace TinTucBongDa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
