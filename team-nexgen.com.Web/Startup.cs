using Microsoft.Owin;
using Owin;
[assembly: OwinStartupAttribute(typeof(team_nexgen.com.Startup))]
namespace team_nexgen.com {
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}