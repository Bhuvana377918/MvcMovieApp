using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcMovieApp.Startup))]
namespace MvcMovieApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
