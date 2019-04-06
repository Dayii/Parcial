using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCparcial5.Startup))]
namespace MVCparcial5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
