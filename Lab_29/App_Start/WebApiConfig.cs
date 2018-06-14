using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Lab_29
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //remove the xml formatter,so the next one will show Json
            config.Formatters.Remove(config.Formatters.XmlFormatter);


            // this line will stop the infiti loop caused by the navigation
            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
