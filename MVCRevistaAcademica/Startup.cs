using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCRevistaAcademica.Startup))]
namespace MVCRevistaAcademica
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
