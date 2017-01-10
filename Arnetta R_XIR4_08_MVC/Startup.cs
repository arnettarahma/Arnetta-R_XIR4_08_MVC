using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Arnetta_R_XIR4_08_MVC.Startup))]
namespace Arnetta_R_XIR4_08_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
