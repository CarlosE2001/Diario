using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DiarioWebEntity.Startup))]
namespace DiarioWebEntity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
