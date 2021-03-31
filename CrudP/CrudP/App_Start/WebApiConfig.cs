﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;

namespace CrudP
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableCors();
            // Configuración y servicios de Web API
            // Configure Web API para usar solo la autenticación de token de portador.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Rutas de Web API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings
            .Add(new System.Net.Http.Formatting.RequestHeaderMapping("Accept",
                    "text/html",
                    StringComparison.InvariantCultureIgnoreCase,
                    true,
                    "application/json"));
        }
    }
}
