using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigSchool01.Startup))]
namespace BigSchool01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
