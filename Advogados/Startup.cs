using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Advogados.Startup))]
namespace Advogados
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
