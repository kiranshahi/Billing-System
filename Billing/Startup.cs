using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Billing.Startup))]
namespace Billing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
