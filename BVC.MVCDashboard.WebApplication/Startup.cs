using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BVC.MVCDashboard.WebApplication.Startup))]
namespace BVC.MVCDashboard.WebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
