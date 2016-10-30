using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMusicStore_Team8.Startup))]
namespace MVCMusicStore_Team8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
