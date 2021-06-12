using System;

using Microsoft.Extensions.DependencyInjection;

namespace HolisticWare.Ph4ct3x.Server
{
    public static partial class StartupAPIWebAPI
    {
        public static IServiceCollection ConfigureServicesAPIWebAPISwagger(this IServiceCollection services)
        {
            /*
                <PackageReference Include="Swashbuckle.AspNetCore.SwaggerGen" Version="1.1.0" />
                <PackageReference Include="Swashbuckle.AspNetCore.Swagger" Version="1.1.0" />
                <PackageReference Include="Swashbuckle.AspNetCore.SwaggerUI" Version="1.1.0" />
            */            
            services.AddSwaggerGen
                    (
                        c =>
                        {
                            c.SwaggerDoc
                                (
                                    Settings.Ph4ct3xSettings.APIVersion,
                                    new Swashbuckle.AspNetCore.Swagger.Info
                                    {
                                        Title = Settings.Ph4ct3xSettings.Title,
                                        Version = Settings.Ph4ct3xSettings.APIVersion
                                    }
                                );
                        }
                   );

            services.ConfigureSwaggerGen
                        (
                            options =>
                            {
                                options.DescribeAllEnumsAsStrings();
                            }
                        );

            return services;
        }
    }
}
