﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace FileUpdate
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                     name: "DefaultApi",
                     routeTemplate: "api/{controller}/{action}/{id}",
                     defaults: new { id = RouteParameter.Optional }
                 );
        }
    }
}