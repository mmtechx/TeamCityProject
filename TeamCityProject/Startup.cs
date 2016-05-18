using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamCityProject.Startup))]
namespace TeamCityProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
