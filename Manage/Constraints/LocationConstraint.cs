using Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Constraints
{
    public class LocationConstraint : IRouteConstraint
    {
        private readonly IServiceProvider serviceProvider;

        public LocationConstraint(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();
                var locations = unitOfWork.Location.GetNames();
                return locations.Contains(values[routeKey]);
            }
        }
    }
}
