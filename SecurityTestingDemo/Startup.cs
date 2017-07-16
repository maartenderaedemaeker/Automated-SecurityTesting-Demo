using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecurityTestingDemo.Startup))]
namespace SecurityTestingDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
