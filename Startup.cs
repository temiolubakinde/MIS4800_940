using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MIS4800_940.Startup))]
namespace MIS4800_940
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
