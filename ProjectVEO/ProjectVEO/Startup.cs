using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectVEO.Startup))]
namespace ProjectVEO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
