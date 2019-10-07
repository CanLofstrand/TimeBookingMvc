using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimeBookingMVC.Startup))]
namespace TimeBookingMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
