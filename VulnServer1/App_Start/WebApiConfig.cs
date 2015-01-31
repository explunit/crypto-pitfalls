using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace VulnServer1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

			// force JSON response
			var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault( t => t.MediaType == "application/xml" );
			config.Formatters.XmlFormatter.SupportedMediaTypes.Remove( appXmlType );
        }
    }
}
