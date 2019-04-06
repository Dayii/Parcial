using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCparcial4.Startup))]
namespace MVCparcial4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
