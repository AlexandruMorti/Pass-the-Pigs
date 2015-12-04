using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PassThePigs.Web.Startup))]
namespace PassThePigs.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
