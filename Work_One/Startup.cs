using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Work_One.Startup))]
namespace Work_One
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
