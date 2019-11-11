using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Smartmom4.Startup))]
namespace Smartmom4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
