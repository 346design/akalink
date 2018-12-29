using System;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.DependencyInjection;

namespace MishiroDesign.Akalink.Extensions
{
    public static class ApplicationPartManagerServiceExtensions
    {
        public static IServiceCollection AddApplicationPartManager(this IServiceCollection services, Type type)
        {
            var applicationPartManager = new ApplicationPartManager();
            applicationPartManager.ApplicationParts.Add(new AssemblyPart(type.Assembly));
            services.Add(new ServiceDescriptor(typeof(ApplicationPartManager), applicationPartManager));

            return services;
        }
    }
}
