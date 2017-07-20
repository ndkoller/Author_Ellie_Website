using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ebkoller_website.Startup))]
namespace ebkoller_website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
