using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(INFS3204Prac1.Startup))]
namespace INFS3204Prac1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
