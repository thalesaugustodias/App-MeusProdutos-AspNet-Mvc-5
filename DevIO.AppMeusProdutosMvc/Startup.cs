using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevIO.AppMeusProdutosMvc.Startup))]
namespace DevIO.AppMeusProdutosMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
