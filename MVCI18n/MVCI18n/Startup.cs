using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCI18n.Startup))]
namespace MVCI18n
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
