using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodMe.Web.Startup))]
namespace FoodMe.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
