using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DankSmiteOnline2.Startup))]
namespace DankSmiteOnline2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
