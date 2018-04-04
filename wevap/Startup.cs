using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wevap.Startup))]
namespace wevap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
