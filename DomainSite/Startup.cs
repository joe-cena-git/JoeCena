using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DomainSite.Startup))]
namespace DomainSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
