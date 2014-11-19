using System.Web.Mvc;
using System.Web.Routing;
using Orchard.Mvc.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Rimango.BootstrapValidation
{
    public class Routes : IRouteProvider
    {
        public void GetRoutes(ICollection<RouteDescriptor> routes)
        {
            foreach (var routeDescriptor in GetRoutes())
                routes.Add(routeDescriptor);
        }

        public IEnumerable<RouteDescriptor> GetRoutes()
        {
            return new[] {
                new RouteDescriptor {
                    Priority = 5,
                    Route = new Route("ValidateUserName",
                        new RouteValueDictionary {
                            {"area", "Rimango.BootstrapValidation"},
                            {"controller", "Validation"},
                            {"action", "ValidateUserName"}
                        },
                        new RouteValueDictionary(),
                        new RouteValueDictionary {
                            {"area", "Rimango.BootstrapValidation"}
                        },
                        new MvcRouteHandler())
                },
                new RouteDescriptor {
                    Priority = 4,
                    Route = new Route("ValidateUserEmail",
                        new RouteValueDictionary {
                            {"area", "Rimango.BootstrapValidation"},
                            {"controller", "Validation"},
                            {"action", "ValidateUserEmail"}
                        },
                        new RouteValueDictionary(),
                        new RouteValueDictionary {
                            {"area", "Rimango.BootstrapValidation"}
                        },
                        new MvcRouteHandler())
                },
                new RouteDescriptor {
                    Priority = 4,
                    Route = new Route("ValidateUserNameEmail",
                        new RouteValueDictionary {
                            {"area", "Rimango.BootstrapValidation"},
                            {"controller", "Validation"},
                            {"action", "ValidateUserNameEmail"}
                        },
                        new RouteValueDictionary(),
                        new RouteValueDictionary {
                            {"area", "Rimango.BootstrapValidation"}
                        },
                        new MvcRouteHandler())
                }
            };
        }
    }
}