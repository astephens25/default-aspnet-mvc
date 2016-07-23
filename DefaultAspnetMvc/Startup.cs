using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DefaultAspnetMvc.Startup))]
namespace DefaultAspnetMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
