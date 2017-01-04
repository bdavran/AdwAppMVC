using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdwApp.MCV.Startup))]
namespace AdwApp.MCV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
