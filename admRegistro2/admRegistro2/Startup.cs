using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(admRegistro2.Startup))]
namespace admRegistro2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
