using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Er_Diagramm_001.Startup))]
namespace Er_Diagramm_001
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
