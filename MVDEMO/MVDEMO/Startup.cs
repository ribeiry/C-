using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVDEMO.Startup))]
namespace MVDEMO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
