using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkersIndia.Startup))]
namespace WorkersIndia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
