using System;
using Forgebase.Masterdata.Core.Interfaces;
using Forgebase.Masterdata.Core.Interfaces.Material;
using Forgebase.Masterdata.Infrastructure.Data;
using Forgebase.Masterdata.Infrastructure.Repositories.Material;
using Microsoft.Extensions.DependencyInjection;

namespace Forgebase.Masterdata
{
    public static class ServiceRegistry
    {
        public static IServiceCollection AddScopedServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IAsyncRepository<,>), typeof(EfRepository<,>));
            services.AddScoped<IColorCodeRepository, ColorCodeService>();

            return services;
        }
    }
}
