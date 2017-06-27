using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TreinamentoCrud.Startup))]
namespace TreinamentoCrud
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
