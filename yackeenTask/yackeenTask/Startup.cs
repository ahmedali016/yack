using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(yackeenTask.Startup))]
namespace yackeenTask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
