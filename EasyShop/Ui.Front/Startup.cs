using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ui.Front.Startup))]
namespace Ui.Front
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
