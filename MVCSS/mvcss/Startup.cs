using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCSS.Startup))]
namespace MVCSS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
