using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnimalGame.Startup))]
namespace AnimalGame
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
