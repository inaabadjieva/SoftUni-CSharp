using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fruit_Game.Startup))]
namespace Fruit_Game
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
