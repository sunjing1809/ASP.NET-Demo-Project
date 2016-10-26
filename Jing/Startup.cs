using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jing.Startup))]
namespace Jing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
