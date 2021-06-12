using System;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace HolisticWare.Ph4ct3x.Server
{
    public static partial class StartupSessionTempData
    {
        public static IServiceCollection ConfigureServicesSessionTempData(this IServiceCollection services)
        {
            /*
                <PackageReference Include="Microsoft.AspNetCore.Session" Version="2.0.1" />
            */ 
            services
                // Adds a default in-memory implementation of IDistributedCache.
                .AddDistributedMemoryCache()
                .AddSession
                    (
                        options =>
                        {
                            // Set a short timeout for easy testing.
                            options.IdleTimeout = TimeSpan.FromSeconds(Settings.Ph4ct3xSettings.SessionTimeOut);
                            options.Cookie.Name = $".{Settings.Ph4ct3xSettings.Name}.Session";
                            options.Cookie.HttpOnly = true;

                        }
                    );

            return services;
        }
    }
}
