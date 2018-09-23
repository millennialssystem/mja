using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyHouse.Startup))]
namespace MyHouse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
