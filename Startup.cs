using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Centric_Consulting_Project_Team_9.Startup))]
namespace Centric_Consulting_Project_Team_9
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
