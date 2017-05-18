using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rental_Application.Startup))]
namespace Rental_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
