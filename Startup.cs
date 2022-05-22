using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Proyect.Startup))]
namespace MVC_Proyect
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
