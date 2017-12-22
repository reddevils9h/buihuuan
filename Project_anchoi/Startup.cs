using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_anchoi.Startup))]
namespace Project_anchoi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
