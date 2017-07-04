using Nemiro.OAuth;
using System;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FoodMe.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            OAuthManager.RegisterClient
              (
                "yahoo",
                "dj0yJmk9Qm1vZ3p2TmtQUm4zJmQ9WVdrOU4wbGlkWGxJT" +
                "kc4bWNHbzlNQS0tJnM9Y29uc3VtZXJzZWNyZXQmeD0xZQ--",
                "a55738627652db0acfe464de2d9be13963b0ba1f"
              );
            OAuthManager.RegisterClient
                (
                  "twitter",
                  "cXzSHLUy57C4gTBgMGRDuqQtr",
                  "3SSldiSb5H4XeEMOIIF4osPWxOy19jrveDcPHaWtHDQqgDYP9P"
                );
        }
    }
}
