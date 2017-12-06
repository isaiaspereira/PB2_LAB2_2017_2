using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppProva2blab2Isaias_Pereira.Startup))]
namespace WebAppProva2blab2Isaias_Pereira
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
