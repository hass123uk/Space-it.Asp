using Microsoft.Owin;
using Owin;
using Space_it.Web;

[assembly: OwinStartup(typeof(Startup))]
namespace Space_it.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
