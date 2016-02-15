using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MunicipalityValuations.Startup))]
namespace MunicipalityValuations
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
