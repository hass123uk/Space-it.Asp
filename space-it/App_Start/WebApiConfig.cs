using System.Net.Http.Formatting;
using System.Web.Http;
using Space_it.Core.Helpers;

namespace Space_it.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Services.Replace(typeof(IContentNegotiator), new JsonContentNegotiator(new JsonMediaTypeFormatter()));

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}